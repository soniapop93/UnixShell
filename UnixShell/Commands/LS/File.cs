namespace UnixShell.Commands.LS
{
    public class File
    {
        public string fileName { get; set; }
        public string path { get; set; }

        public File(string fileName, string path)
        {
            this.fileName = fileName;
            this.path = path;
        }
    }
}
