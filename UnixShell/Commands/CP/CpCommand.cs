using System;

namespace UnixShell.Commands.CP
{
    public class CpCommand
    {
        public void cpCommand(string path, string currentfileName, string newFileName)
        {
            
            File.Copy(Path.Combine(path, currentfileName), Path.Combine(path, newFileName));
        }
    }
}
