using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnixShell.Commands.LS
{
    public class LsCommand
    {
        List<File> files = new List<File>();
        List<Directory> directories = new List<Directory>();

        public void lsCommand(string path)
        {
            directories.Clear();
            files.Clear();

            string[] dirs = System.IO.Directory.GetDirectories(path);
            string[] fils = System.IO.Directory.GetFiles(path, "*");

            for (int i = 0; i < dirs.Length; i++)
            {
                string directoryName = regexMatchDirectoryName(dirs[i]);

                Directory dir = new Directory(directoryName, dirs[i]);
                
                directories.Add(dir);
            }

            for (int i = 0; i < fils.Length; i++)
            {
                string fileName = regexMatchFileName(fils[i]);

                File file = new File(fileName, fils[i]);
                files.Add(file);
            }

            displayOutput();
        }

        private string regexMatchFileName(string pathFile)
        {
            Match m = Regex.Match(pathFile, @".+\\(.+\.*)");

            return m.Groups[1].Value;
        }

        private string regexMatchDirectoryName(string pathFile)
        {
            Match m = Regex.Match(pathFile, @".+\\(.+)");

            return m.Groups[1].Value;
        }

        private string createOutput()
        {
            string output = "";

            if (directories.Count > 0)
            {
                for (int i = 0; i < directories.Count; i++)
                {
                    output += directories[i].directoryName + "\n";
                }
            }

            if (files.Count > 0)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    output += files[i].fileName + "\n";
                }
            }

            return output;
        }

        private void displayOutput()
        {
            Console.WriteLine(createOutput());
        }
    }
}
