using System;

namespace UnixShell.Commands.CP
{
    public class CpCommand
    {
        public void cpCommand(string path, string fileName, string newFilePath)
        {
            
            File.Copy(Path.Combine(path, fileName), Path.Combine(newFilePath, fileName));
        }
    }
}
