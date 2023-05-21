using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace DuplicateFilesOrginaizer
{
    public class Organizer
    {
        private readonly BackgroundWorker _backgroundWorker = new BackgroundWorker();
        private readonly BaseOrganizer _baseOrganize;
        private readonly ImagesOrganizer _imagesOrganizer;
        private readonly MovieOrganizer _movieOrganizer;

        private ApplicationSettings _settings = new ApplicationSettings();

        private int _total;
        public List<string> Documents = new List<string>();
        public List<string> General = new List<string>();
        public List<string> Images = new List<string>();
        public List<string> Movies = new List<string>();

        public Organizer()
        {
            _backgroundWorker.DoWork += Run;
            _backgroundWorker.ProgressChanged += BackgroundWorkerProgressChanged;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorkerFinish;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;


            _baseOrganize = new BaseOrganizer();
            _baseOrganize.OrganizedFile += OrganizerOrganizedFile;
            _baseOrganize.OrganizedFileFailed += OrganizedFileFailedEventReceived;
            _baseOrganize.ProgressChanged += ProgressChangedEventReceived;
            _baseOrganize.DuplicateOrganizedFile += DuplicateOrganizedFileEventReceived;


            _imagesOrganizer = new ImagesOrganizer(_settings);
            _imagesOrganizer.OrganizedFile += OrganizerOrganizedFile;
            _imagesOrganizer.OrganizedFileFailed += OrganizedFileFailedEventReceived;
            _imagesOrganizer.ProgressChanged += ProgressChangedEventReceived;
            _imagesOrganizer.DuplicateOrganizedFile += DuplicateOrganizedFileEventReceived;

            _movieOrganizer = new MovieOrganizer(_settings);
            _movieOrganizer.OrganizedFile += OrganizerOrganizedFile;
            _movieOrganizer.OrganizedFileFailed += OrganizedFileFailedEventReceived;
            _movieOrganizer.ProgressChanged += ProgressChangedEventReceived;
            _movieOrganizer.DuplicateOrganizedFile += DuplicateOrganizedFileEventReceived;
        }

        public int _fileProcessCounter { get; set; }

        // Events (5) 

        public event EventHandler<DuplicateEventArgs> DuplicateOrganizedFile;

        public event EventHandler<StringEventArgs> RetrieveAllFilesFinished;

        public event EventHandler<StringEventArgs> OrganizedFile;

        public event EventHandler<StringEventArgs> OrganizedFileFailed;

        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
        public event EventHandler<EventArgs> Finished;

        protected virtual void OnFinished()
        {
            var handler = Finished;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        // Public Methods (1) 

        public void RunAnsync(ApplicationSettings settings)
        {
            if (!_backgroundWorker.IsBusy)
            {
                _settings = settings;
                _backgroundWorker.RunWorkerAsync();
            }
        }
        // Protected Methods (7) 

        protected void Run(object sender, DoWorkEventArgs e)
        {
            OnProgressChanged(new ProgressChangedEventArgs(0, "Working..."));

            var retriveAndGroupFiles = RetrieveAndGroupFiles();
            ProcessFiles(Documents, "Documents");
            _fileProcessCounter = Documents.Count;
            ProcessFiles(General, "General");
            _fileProcessCounter += General.Count;

            ProcessPictureFiles(Images);
            ProcessMovieFiles(Movies);
        }

        protected void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            OnProgressChanged(e);
        }

        protected virtual void OnDuplicateOrganizedFile(DuplicateEventArgs e)
        {
            //File.Delete(e.FilePath);
            var handler = DuplicateOrganizedFile;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnRetrieveAllFilesFinished(StringEventArgs e)
        {
            var handler = RetrieveAllFilesFinished;
            if (handler != null) handler(null, e);
        }

        protected virtual void OnOrganizedFile(StringEventArgs e)
        {
            var handler = OrganizedFile;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnOrganizedFileFailed(string e)
        {
            var handler = OrganizedFileFailed;
            if (handler != null) handler(this, new StringEventArgs(e));
        }

        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
            var handler = ProgressChanged;
            if (handler != null) handler(this, e);
        }
        // Private Methods (8) 

        private void DuplicateOrganizedFileEventReceived(object sender, DuplicateEventArgs e)
        {
            OnDuplicateOrganizedFile(e);
            if (_settings.DeleteDuplicateFiles) File.Delete(e.FilePath);
        }

        private void OrganizedFileFailedEventReceived(object sender, ProgressChangedEventArgs e)
        {
            OnOrganizedFileFailed(e.UserState.ToString());
        }

        private void ProgressChangedEventReceived(object sender, ProgressChangedEventArgs e)
        {
            var value = _fileProcessCounter + e.ProgressPercentage;
            var d = 100 * (double)value / _total;
            value = (int)d;
            e = new ProgressChangedEventArgs(value, e.UserState);
            OnProgressChanged(e);
        }

        private void BackgroundWorkerFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            OnFinished();
        }

        private void OrganizerOrganizedFile(object sender, ProgressChangedEventArgs e)
        {
            OnOrganizedFile(new StringEventArgs(e.UserState.ToString()));
        }

        private void ProcessFiles(List<string> files, string group)
        {
            _baseOrganize.Total = _total;
            _baseOrganize.Group = group;
            _baseOrganize.Run(_settings, files);
        }

        private void ProcessPictureFiles(List<string> files)
        {
            _imagesOrganizer.Group = "Pictures";
            _imagesOrganizer.Run(_settings, files);
        }

        private void ProcessMovieFiles(List<string> files)
        {
            _movieOrganizer.Group = "Movies";
            _movieOrganizer.Run(_settings, files);
        }

        private int RetrieveAndGroupFiles()
        {
            Documents.Clear();
            Images.Clear();
            Movies.Clear();
            General.Clear();
            foreach (var fileExtension in _settings.Extensions)
                switch (fileExtension.Group)
                {
                    case "Documents":
                        Documents.AddRange(
                            FilesSearcher.EnumerateFiles(_settings.SearchFolder, fileExtension.Pattern,
                                _settings.SearchOption));
                        break;
                    case "Images":
                        Images.AddRange(
                            FilesSearcher.EnumerateFiles(_settings.SearchFolder, fileExtension.Pattern,
                                _settings.SearchOption));
                        break;
                    case "Movies":
                        Movies.AddRange(
                            FilesSearcher.EnumerateFiles(_settings.SearchFolder, fileExtension.Pattern,
                                _settings.SearchOption));
                        break;
                    case "General":
                        General.AddRange(
                            FilesSearcher.EnumerateFiles(_settings.SearchFolder, fileExtension.Pattern,
                                _settings.SearchOption));
                        break;
                }

            var sum = _total = Documents.Count + Images.Count + Movies.Count + General.Count;
            OnRetrieveAllFilesFinished(new StringEventArgs(sum.ToString()));
            return sum;
        }
    }
}