using System;

namespace DuplicateFilesOrginaizer
{
    public class StringEventArgs : EventArgs
    {
        public StringEventArgs(string message)
        {
            Message = message;
        }

        public StringEventArgs()
        {
            Message = "";
        }

        public string Message { get; set; }
    }
}