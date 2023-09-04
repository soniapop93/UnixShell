using System;
using System.Collections.Generic;

namespace UnixShell.Commands.TOUCH
{
    public class TouchCommand
    {
        public void touchCommand(string path, string fileName)
        {
            using (FileStream fs = File.Create(path + "\\" + fileName));
        }
    }
}