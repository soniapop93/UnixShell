using System;

namespace UnixShell.Commands.MV
{
    public class MvCommand
    {
        public void mvCommand(string path, string fileName, string newPath)
        {
            if (newPath.Contains("\\")) 
            {
                File.Move(Path.Combine(path, fileName), Path.Combine(newPath, fileName));
            }
            else
            {
                File.Move(Path.Combine(path, fileName), Path.Combine(path, newPath));
            }
        }
    }
}
