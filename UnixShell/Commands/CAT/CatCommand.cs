using System;
using System.Collections.Generic;

namespace UnixShell.Commands.CAT
{
    public class CatCommand
    {
        public void catCommand(string path, string[] files)
        {
            for (int i = 1; i < files.Length; i++)
            {
                Console.WriteLine(File.ReadAllText(path + "//" + files[i]));
            }
        }
    }
}
