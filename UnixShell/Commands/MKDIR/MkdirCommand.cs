using System;
using System.IO;
using System.Collections.Generic;

namespace UnixShell.Commands.MKDIR
{
    public class MkdirCommand
    {
        public void mkdirCommand(string path, string dirName)
        {
            if (!checkIfDirExists(path, dirName))
            {
                Directory.CreateDirectory(path + "/" + dirName);
            }
            else
            {
                Console.WriteLine("An item with the specified name {0} already exists.", path + "\\" + dirName);
            }

        }

        private bool checkIfDirExists(string path, string dirName)
        {
            return Directory.Exists(path + "/" + dirName);
        }
    }
}
