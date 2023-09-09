using System;

namespace UnixShell.Commands.RM
{
    public class RmCommand
    {
        public void rmCommand(bool isDir, string path, string fileName)
        {
            if (isDir)
            {
                Directory.Delete(Path.Combine(path, fileName));
            }
            else
            {
                File.Delete(Path.Combine(path, fileName));
            }
        }
    }
}
