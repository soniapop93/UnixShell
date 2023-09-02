using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnixShell.Commands.LS;

namespace UnixShell.Logic
{
    public class Shell
    {
        readonly string homePath = "C:\\Users\\" + System.Environment.UserName;
        readonly string commandsStr = "";

        LsCommand ls = new LsCommand();

        public void shell()
        {
            while (true)
            {
                string command = userInput();

                if (!String.IsNullOrEmpty(command))
                {
                    switch (command)
                    {
                        default:
                            Console.WriteLine("Command was not recognized. Please choose one of the following commands: \\n" + commandsStr);
                            break;

                        case "pwd":
                            //TODO: implement pwd
                            break;

                        case "ls":
                            ls.lsCommand(homePath);
                            break;

                        case "cd":
                            //TODO: implement cd
                            break;

                        case "cp":
                            //TODO: implement cp
                            break;

                        case "mv":
                            //TODO: implement mv
                            break;

                        case "rm":
                            //TODO: implememnt rm
                            break;

                        case "mkdir":
                            //TODO: implement mkdir
                            break;

                        case "echo":
                            //TODO: implement echo
                            break;

                        case "touch":
                            //TODO: implement touch
                            break;

                        case "cat":
                            //TODO: implement cat
                            break;

                        case "grep":
                            //TODO: implement grep
                            break;

                        case "pipes":
                            //TODO: implement pipes
                            break;

                        case "exit":
                            return;
                    }
                }
               
            }
        }

        private string userInput()
        {
            string inputUser = Console.ReadLine();

            return inputUser;
        } 
    }
}
