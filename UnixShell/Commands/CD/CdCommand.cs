using System;
using System.Collections.Generic;

namespace UnixShell.Commands.CD
{
    public class CdCommand
    {
        public string cdCommand(string path, string folder)
        {
            return path + "\\" + folder;
        }

        public string cdPreviousFolder(string path)
        {
            DirectoryInfo dirInfo = Directory.GetParent(path);

            return dirInfo.FullName;
        }
    }
}
