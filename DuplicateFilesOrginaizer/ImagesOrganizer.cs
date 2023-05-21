using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DuplicateFilesOrginaizer
{
    public sealed class ImagesOrganizer : BaseOrganizer
    {
        private static readonly Regex _regex = new Regex(":");

        public ImagesOrganizer(ApplicationSettings settings)
            : base(settings)
        {
        }

        public ImagesOrganizer()
            : base(new ApplicationSettings())
        {
            Group = "Images";
        }


        public static DateTime GetDateTakenFromImage(FileInfo fi)
        {
            var dt = fi.LastWriteTime;
            try
            {
                using (var fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                using (var myImage = Image.FromStream(fs, false, false))
                {
                    var propItem = myImage.GetPropertyItem(36867);
                    var dateTaken = _regex.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    dt = DateTime.Parse(dateTaken);
                }
            }
            catch
            {
            }

            return dt;
        }

        protected override string GetNewFileName(FileInfo fi, int value)
        {
            var fileName = GetDateFormatFull(GetDateTakenFromImage(fi));

            if (value > 0)
                return fileName + value + fi.Extension;
            return fileName + fi.Extension;
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