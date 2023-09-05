using UnixShell.Commands.CAT;
using UnixShell.Commands.CD;
using UnixShell.Commands.ECHO;
using UnixShell.Commands.LS;
using UnixShell.Commands.MKDIR;
using UnixShell.Commands.TOUCH;

namespace UnixShell.Logic
{
    public class Shell
    {
        readonly string homePath = "C:\\Users\\" + System.Environment.UserName;
        readonly string commandsStr = String.Join("\n", new List<string> { "ls", "pwd", "cd", "cp", "mv", "rm", "mkdir", "echo", "touch", "cat", "grep"});

        LsCommand ls = new LsCommand();
        MkdirCommand mkdir = new MkdirCommand();
        EchoCommand echo = new EchoCommand();
        TouchCommand touch = new TouchCommand();
        CatCommand cat = new CatCommand();
        CdCommand cd = new CdCommand();

        public void shell()
        {
            string path = homePath;
            string previousPath = homePath;

            while (true)
            {
                Console.Write(">> ");
                string command = userInput();

                if (!String.IsNullOrEmpty(command))
                {
                    string[] splittedCommand = command.Split(" ");

                    switch (splittedCommand[0].ToString())
                    {
                        default:
                            Console.WriteLine("Command was not recognized. Please choose one of the following commands: \n" + commandsStr);
                            break;

                        case "pwd":
                            //TODO: implement pwd
                            break;

                        case "ls":
                            ls.lsCommand(path);
                            break;

                        case "cd":
                            previousPath = path;
                            path = cd.cdCommand(path, splittedCommand[1]);
                            break;

                        case "cd..":
                            path = previousPath;
                            //TODO: not finished, is not working properly yet
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
                            mkdir.mkdirCommand(path, "");
                            break;

                        case "echo":
                            echo.echoCommand(splittedCommand);
                            break;

                        case "touch":
                            touch.touchCommand(path, splittedCommand);
                            break;

                        case "cat":
                            cat.catCommand(path, splittedCommand);
                            break;

                        case "grep":
                            //TODO: implement grep
                            break;

                        case "exit":
                            return;
                    }
                    Console.WriteLine("-------------");
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
