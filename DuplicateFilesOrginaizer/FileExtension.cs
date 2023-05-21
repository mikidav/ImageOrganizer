namespace DuplicateFilesOrginaizer
{
    public class FileExtension
    {
        public FileExtension()
        {
        }

        public FileExtension(string group, string pattaren)
        {
            Group = group;
            Pattern = pattaren;
        }

        public string Group { get; set; }
        public string Pattern { get; set; }
    }
}