using System;

namespace DuplicateFilesOrginaizer
{
    public class DuplicateEventArgs : EventArgs
    {
        public DuplicateEventArgs(string message, string filePath)
        {
            // TODO: Complete member initialization
            Message = message;
            FilePath = filePath;
        }

        public string Message { get; set; }

        public string FilePath { get; set; }
    }
}