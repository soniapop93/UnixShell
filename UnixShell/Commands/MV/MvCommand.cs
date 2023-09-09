using System;

namespace UnixShell.Commands.MV
{
    public class MvCommand
    {
        public void mvCommand(string path, string currentfileName, string newFileName)
        {
            File.Move(Path.Combine(path, currentfileName), Path.Combine(path, newFileName));
        }
    }
}
