using System;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;

namespace DuplicateFilesOrginaizer
{
    public sealed class MovieOrganizer : BaseOrganizer
    {
        public MovieOrganizer(ApplicationSettings settings)
            : base(settings)
        {
        }

        public MovieOrganizer()
            : base(new ApplicationSettings())
        {
            Group = "Movie";
        }

        protected override string GetNewFileName(FileInfo fi, int value)
        {
            var fileName = GetDateFormatFull(fi);

            if (value > 0)
                return fileName + value + fi.Extension;
            return fileName + fi.Extension;
        }

        private string GetDateFormatFull(FileInfo fi)
        {
            var dt = fi.LastWriteTime;
            // Read and Write:

            var shell = ShellObject.FromParsingName(fi.FullName);
            try
            {
                var data = shell.Properties.System.Media.DateEncoded;
                dt = data.Value.Value;
            }
            catch (Exception)
            {
                //throw;
            }

            return GetDateFormatFull(dt);
        }

        /// <summary>
        ///     return  full Date format yyyy_MM_dd_HH_mm_ss_ffff
        /// </summary>
        /// <param name="value">date as dateTime</param>
        /// <returns>date as string</returns>
        public static string GetDateFormatFull(DateTime value)
        {
            const string DateFormatFull = "yyyy_MM_dd_HH_mm_ss_ffff";
            return $"{value.ToString(DateFormatFull)}";
        }
    }
}