using System;
using System.Collections.Generic;

namespace UnixShell.Commands.TOUCH
{
    public class TouchCommand
    {
        public void touchCommand(string path, string[] filesNames)
        {
            for (int i = 0; i < filesNames.Length; i++)
            {
                using (FileStream fs = File.Create(path + "\\" + filesNames[i]));
            }
        }
    }
}