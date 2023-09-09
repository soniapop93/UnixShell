using UnixShell.Commands.CAT;
using UnixShell.Commands.CD;
using UnixShell.Commands.CP;
using UnixShell.Commands.ECHO;
using UnixShell.Commands.LS;
using UnixShell.Commands.MKDIR;
using UnixShell.Commands.MV;
using UnixShell.Commands.PWD;
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
        PwdCommand pwd = new PwdCommand();
        CpCommand cp = new CpCommand();
        MvCommand mv = new MvCommand();

        public void shell()
        {
            string path = homePath;

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
                            pwd.pwdCommand(path);
                            break;

                        case "ls":
                            ls.lsCommand(path);
                            break;

                        case "cd":
                            if (splittedCommand.Length > 1)
                            {
                                if (splittedCommand[1].Equals(".."))
                                {
                                    path = cd.cdPreviousFolder(path);
                                }
                                else
                                {
                                    path = cd.cdCommand(path, splittedCommand[1]);
                                }
                            }
                            break;

                        case "cp":

                            if (splittedCommand.Length == 3)
                            {
                                cp.cpCommand(path ,splittedCommand[1], splittedCommand[2]);
                            }
                            break;

                        case "mv":
                            
                            if (splittedCommand.Length == 3)
                            {
                                mv.mvCommand(path, splittedCommand[1], splittedCommand[2]);
                            }
                            break;

                        case "rm":
                            //TODO: implememnt rm
                            break;

                        case "mkdir":
                            if (splittedCommand.Length == 2)
                            {
                                mkdir.mkdirCommand(path, splittedCommand[1]);
                            }
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
