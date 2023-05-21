namespace DuplicateFilesOrginaizer
{
    public sealed class DocumentsOrganizer : BaseOrganizer
    {
        public DocumentsOrganizer(ApplicationSettings settings)
            : base(settings)
        {
        }

        public DocumentsOrganizer() : base(new ApplicationSettings())
        {
            Group = "Documents";
        }
    }

    public sealed class GeneralOrganizer : BaseOrganizer
    {
        public GeneralOrganizer(ApplicationSettings settings)
            : base(settings)
        {
        }

        public GeneralOrganizer()
            : base(new ApplicationSettings())
        {
            Group = "General";
        }
    }
}