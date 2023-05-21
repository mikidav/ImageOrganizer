using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace DuplicateFilesOrginaizer
{
    public class BaseOrganizer
    {
        private int _fileCount;
        private Dictionary<string, int> _hashCounter = new Dictionary<string, int>();
        private Dictionary<string, string> _hashFile = new Dictionary<string, string>();
        private ApplicationSettings _settings;

        public BaseOrganizer(ApplicationSettings settings)
        {
            _settings = settings;
            if (settings == null)
            {
                _settings = new ApplicationSettings();
            }
        }

        public BaseOrganizer()
            : this(new ApplicationSettings())
        {
        }

        public virtual string Group { get; set; }

        public int Total { get; set; }

        // Events (4) 

        public event EventHandler<DuplicateEventArgs> DuplicateOrganizedFile;

        public event EventHandler<ProgressChangedEventArgs> OrganizedFile;

        public event EventHandler<ProgressChangedEventArgs> OrganizedFileFailed;

        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;

        // Public Methods (1) 

        public virtual void Run(ApplicationSettings settings, List<string> files)
        {
            _settings = settings;
            _hashFile = new Dictionary<string, string>();
            _hashCounter = new Dictionary<string, int>();
            _fileCount = files.Count;
            switch (settings.CopyAction)
            {
                case CopyAction.Test:
                    for (var index = 0; index < files.Count; index++)
                    {
                        var file = files[index];
                        OnOrganizedFile(index, $"File checked {file}");
                        OnProgressChanged(index, null);
                    }

                    break;
                case CopyAction.Copy:
                    for (var index = 0; index < files.Count; index++)
                    {
                        var file = files[index];
                        ProcessFileCopy(file, index);
                        OnProgressChanged(index, null);
                    }

                    break;
                case CopyAction.Move:
                    for (var index = 0; index < files.Count; index++)
                    {
                        var file = files[index];
                        ProcessFileMove(file, index);
                        OnProgressChanged(index, null);
                    }

                    break;
            }
        }
        // Protected Methods (6) 

        private FileInfo GetDestination(string file, out bool duplicate, out string dest)
        {
            duplicate = false;
            var fi = new FileInfo(file);
            var fileKey = fi.CreationTime + fi.Length.ToString();
            var fileName = fi.Name;
            var value = 0;
            if (_hashFile.ContainsKey(fileKey))
            {
                duplicate = true;

                if (_hashCounter.ContainsKey(fileKey))
                {
                    value = _hashCounter[fileKey]++;
                }
                else
                {
                    _hashCounter.Add(fileKey, 1);
                    value = 1;
                }
            }
            else
            {
                _hashFile.Add(fileKey, "");
            }

            fileName = GetNewFileName(fi, value);


            dest = $@"{_settings.Destination}{GetMediterraneanFolder(fi)}\{fileName}";
            return fi;
        }

        protected virtual string GetNewFileName(FileInfo fi, int value)
        {
            if (!_settings.RenameAndRemoveDuplicate) return fi.Name;
            var fileName = fi.Name;
            var v = Path.GetFileNameWithoutExtension(fileName) + value + Path.GetExtension(fileName);
            return v;
        }

        private string GetDuplicateNewFileName(string file)
        {
            var count = 0;
            if (_settings.RenameAndRemoveDuplicate)
            {
                if (_hashCounter.ContainsKey(file))
                {
                    count = _hashCounter[file];
                    _hashCounter[file]++;
                    File.Delete(file);
                }
            }
            else
            {
                _hashCounter.Add(file, count);
            }

            return Path.GetFileNameWithoutExtension(file) + count + Path.GetExtension(file);
        }

        protected virtual void OnDuplicateOrganizedFile(DuplicateEventArgs e)
        {
            var handler = DuplicateOrganizedFile;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnOrganizedFile(int index, object userState)
        {
            var temp = new ProgressChangedEventArgs(index, userState);
            var handler = OrganizedFile;
            if (handler != null) handler(this, temp);
        }

        protected virtual void OnOrganizedFileFailed(int index, object userState)
        {
            var temp = new ProgressChangedEventArgs(index, userState);
            var handler = OrganizedFileFailed;
            if (handler != null) handler(this, temp);
        }

        protected virtual void OnProgressChanged(int index, object userState)
        {
            var temp = new ProgressChangedEventArgs(index, userState);
            var handler = ProgressChanged;
            if (handler != null) handler(this, temp);
        }
        // Private Methods (3) 

        protected virtual string GetMediterraneanFolder(FileInfo fi)
        {
            var sb = new StringBuilder();

            if (_settings.SplitByGroups) sb.Append($@"\{Group}");
            if (_settings.MakeYearFolder) sb.Append($@"\{fi.LastWriteTime:yyyy}");
            if (_settings.MakeMonthFolder) sb.Append($@"\{fi.CreationTime:MM}");
            if (_settings.MakeMonthFolderName) sb.Append($@"_{fi.CreationTime:MMM}");
            if (sb.Length == 0)
                sb.Append(@"\");
            return sb.ToString();
        }

        private void ProcessFileCopy(string file, int index)
        {
            bool duplicate;
            string dest;
            var fi = GetDestination(file, out duplicate, out dest);

            try
            {
                CopyFile(file, dest);
                if (!duplicate)
                {
                    var message = $"[]..{fi.FullName} copy -> {dest}";
                    OnOrganizedFile(index, message);
                }
                else
                {
                    if (_settings.RenameAndRemoveDuplicate)
                    {
                        var message = $"[]..{fi.FullName} copy duplicate -> {dest}";
                        OnDuplicateOrganizedFile(new DuplicateEventArgs(message, fi.FullName));
                    }
                    else
                    {
                        var message = $"[]..{fi.FullName} file is duplicated ";

                        OnOrganizedFileFailed(index, message);
                    }
                }
            }
            catch (Exception exception)
            {
                OnOrganizedFileFailed(index, exception.Message);
            }
        }

        private bool CopyFile(string file, string dest)
        {
            var folderPah = Path.GetDirectoryName(dest);
            if (!Directory.Exists(folderPah))
                Directory.CreateDirectory(folderPah);

            File.Copy(file, dest);
            return true;
        }

        private void ProcessFileMove(string file, int index)
        {
            bool duplicate;
            string dest;
            var fi = GetDestination(file, out duplicate, out dest);

            try
            {
                MoveFile(file, dest);
                if (!duplicate)
                {
                    var message = $"[]..{fi.FullName} move -> {dest}";
                    OnOrganizedFile(index, message);
                }
                else
                {
                    if (_settings.RenameAndRemoveDuplicate)
                    {
                        var message = $"[]..{fi.FullName} move duplicate -> {dest}";
                        OnDuplicateOrganizedFile(new DuplicateEventArgs(message, fi.FullName));
                    }
                    else
                    {
                        var message = $"[]..{fi.FullName} file is duplicated ";

                        OnOrganizedFileFailed(index, message);
                    }
                }
            }
            catch (Exception exception)
            {
                OnOrganizedFileFailed(index, exception.Message);
            }
        }

        private bool MoveFile(string file, string dest)
        {
            var folderPah = Path.GetDirectoryName(dest);
            if (!Directory.Exists(folderPah))
                Directory.CreateDirectory(folderPah);
            try
            {
                File.Move(file, dest);
            }
            catch (IOException ex1) // when (ex1.Message== "Cannot create a file when that file already exists.")
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    //throw;
                }
            }


            return false;
        }
    }
}