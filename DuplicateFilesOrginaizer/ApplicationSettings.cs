using System.Collections.Generic;
using System.IO;
using System.Reflection;
//DuplicateFilesOrganizer

namespace DuplicateFilesOrginaizer
{
    public class ApplicationSettings
    {
        public ApplicationSettings(string searchFolder, string destination, string pattern, SearchOption searchOption,
            bool excludeProgramFilesFolder, bool renameAndRemoveDuplicate, CopyAction copyAction,
            FileExtension[] extensions)
        {
            Set(searchFolder, destination, pattern, searchOption, excludeProgramFilesFolder, renameAndRemoveDuplicate,
                copyAction, extensions);
        }

        public ApplicationSettings()
        {
            Set(@"c:\temp", @"c:\temp", "", SearchOption.TopDirectoryOnly,
                true, false, CopyAction.Test, FillFileExtensions().ToArray());
        }

        public CopyAction CopyAction { get; set; }

        public string Destination { get; set; }

        public bool ExcludeProgramFilesFolder { get; set; }

        public FileExtension[] Extensions { get; set; }

        public bool MakeMonthFolder { get; set; }

        public bool MakeMonthFolderName { get; set; }

        public bool MakeYearFolder { get; set; }

        public string Pattern { get; set; }

        public bool RenameAndRemoveDuplicate { get; set; }

        public bool SearchDocuments { get; set; }

        public string SearchFolder { get; set; }

        public bool SearchGeneral { get; set; }

        public bool SearchImages { get; set; }

        public bool SearchMusic { get; set; }

        public SearchOption SearchOption { get; set; }

        public bool SearchVideos { get; set; }

        public bool SplitByGroups { get; set; }

        public bool UseExifDate { get; set; }

        public bool DeleteDuplicateFiles { get; set; }

        public bool DeleteEmptyFolder { get; set; }

        // Public Methods (4) 

        public ApplicationSettings Load()
        {
            var dammy = new ApplicationSettings();
            var folderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var filePath = Path.Combine(folderPath, "Settings.xml");
            return dammy.Load<ApplicationSettings>(filePath);
        }

        public void Reset()
        {
            Set(@"c:\temp", @"c:\temp", "", SearchOption.TopDirectoryOnly, true, false, CopyAction.Test,
                FillFileExtensions().ToArray());
        }

        public void Save()
        {
            var folderPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var filePath = Path.Combine(folderPath, "Settings.xml");
            this.Save<ApplicationSettings>(filePath);
        }

        public void Set(string searchFolder, string destination, string pattern, SearchOption searchOption,
            bool excludeProgramFilesFolder, bool renameAndRemoveDuplicate, CopyAction copyAction,
            FileExtension[] extensions)
        {
            SearchFolder = searchFolder;
            Destination = destination;
            Pattern = pattern;
            SearchOption = searchOption;
            ExcludeProgramFilesFolder = excludeProgramFilesFolder;
            RenameAndRemoveDuplicate = renameAndRemoveDuplicate;
            CopyAction = copyAction;
            Extensions = extensions;
        }
        // Private Methods (1) 

        private static List<FileExtension> FillFileExtensions()
        {
            var fileExtension = new List<FileExtension>
            {
                new FileExtension("Documents", "doc"),
                new FileExtension("Documents", "docx"),
                new FileExtension("Documents", "xls"),
                new FileExtension("Documents", "xlsx"),
                new FileExtension("Documents", "ppt"),
                new FileExtension("Documents", "pptx"),
                new FileExtension("Documents", "txt"),
                new FileExtension("Documents", "text"),
                new FileExtension("Documents", "pdf"),

                new FileExtension("Images", "jpg"),
                new FileExtension("Images", "jpeg"),
                new FileExtension("Images", "bmp"),
                new FileExtension("Images", "gif"),
                new FileExtension("Images", "png"),

                new FileExtension("Movies", "avi"),
                new FileExtension("Movies", "mov"),
                new FileExtension("Movies", "wmv"),
                new FileExtension("Movies", "mkv"),
                new FileExtension("Movies", "rm"),
                new FileExtension("Movies", "mp4"),
                new FileExtension("Movies", "m4p "),
                new FileExtension("Movies", "flv")
            };
            return fileExtension;
        }
    }
}