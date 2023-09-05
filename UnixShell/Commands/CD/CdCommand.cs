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
    }
}
