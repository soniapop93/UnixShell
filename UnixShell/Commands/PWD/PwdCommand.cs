using System;

namespace UnixShell.Commands.PWD
{
    public class PwdCommand
    {
        public void pwdCommand(string path)
        {
            Console.WriteLine(path);
        }
    }
}
