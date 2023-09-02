using System;
using System.Collections.Generic;

namespace UnixShell.Commands.PWD
{
    public class PwdCommand
    {
        public string pwdCommand()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
