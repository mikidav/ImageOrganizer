using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DuplicateFilesOrginaizer
{
    public class FilesSearcher
    {
        public static bool Cancel { get; set; }

        // Events (1) 

        public static event EventHandler<StringEventArgs> SearchFolder;

        // Public Methods (3) 

        public static IEnumerable<string> EnumerateDirectories(string parentDirectory, string searchPattern,
            SearchOption searchOpt)
        {
            try
            {
                var directories = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                    directories = Directory.EnumerateDirectories(parentDirectory)
                        .SelectMany(x => EnumerateDirectories(x, searchPattern, searchOpt));
                return directories.Concat(Directory.EnumerateDirectories(parentDirectory, searchPattern));
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }

        public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var dirFiles = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                    dirFiles = Directory.EnumerateDirectories(path)
                        .SelectMany(x => EnumerateFiles(x, searchPattern, searchOpt));
                var filteredFiles = Directory.EnumerateFiles(path).Where(file => file.ToLower().EndsWith(searchPattern))
                    .ToList();

                return dirFiles.Concat(filteredFiles);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Enumerable.Empty<string>();
            }
        }


        public static void GetFilesInfo(string path, string[] extensions, ref List<FileInfo> filesInfo)
        {
            Cancel = false;
            try
            {
                for (var index = 0; index < extensions.Length; index++)
                    extensions[index] = extensions[index].Replace("*", "");
                OnSearchFolder($"Search in folder {path}");
                var di = new DirectoryInfo(path);

                var infos = di.GetFiles();
                var list1 = new List<FileInfo>();

                foreach (var item in infos)
                {
                    if (Cancel)
                        return;

                    foreach (var item1 in extensions)
                        if (item.Extension == item1)
                            list1.Add(item);
                }

                filesInfo.AddRange(list1);

                var list = Directory.GetDirectories(path).ToList();
                foreach (var s in list)
                {
                    if (Cancel)
                        return;
                    GetFilesInfo(s, extensions, ref filesInfo);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Trace.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
            }
        }

        public static List<string> ParallelGetFiles(string folder, string pattern, SearchOption searchOption)
        {
            var pat = pattern.Split('|');
            var filePathList = new List<string>();

            foreach (var s in pat) filePathList.AddRange(EnumerateFiles(folder, s, searchOption));

            Parallel.ForEach(pat,
                currntPattern => filePathList.AddRange(EnumerateFiles(folder, pattern, searchOption)));
            return filePathList;
        }
        // Protected Methods (1) 

        protected static void OnSearchFolder(string e)
        {
            var handler = SearchFolder;
            if (handler != null) handler(null, new StringEventArgs(e));
        }
    }
}