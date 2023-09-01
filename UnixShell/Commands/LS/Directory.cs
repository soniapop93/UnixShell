namespace UnixShell.Commands.LS
{
    public class Directory
    {
        public string directoryName { get;set; }
        public string directoryPath { get;set; }

        public Directory(string directoryName, string directoryPath)
        {
            this.directoryName = directoryName;
            this.directoryPath = directoryPath;
        }
    }
}
