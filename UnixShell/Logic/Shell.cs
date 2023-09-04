using UnixShell.Commands.ECHO;
using UnixShell.Commands.LS;
using UnixShell.Commands.MKDIR;
using UnixShell.Commands.TOUCH;

namespace UnixShell.Logic
{
    public class Shell
    {
        readonly string homePath = "C:\\Users\\" + System.Environment.UserName;
        readonly string commandsStr = String.Join("\n", new List<string> { "ls", "pwd", "cd", "cp", "mv", "rm", "mkdir", "echo", "touch", "cat", "grep", "pipes" });

        LsCommand ls = new LsCommand();
        MkdirCommand mkdir = new MkdirCommand();
        EchoCommand echo = new EchoCommand();
        TouchCommand touch = new TouchCommand();

        public void shell()
        {
            while (true)
            {
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
                            mkdir.mkdirCommand("", "");
                            
                            break;

                        case "echo":
                            echo.echoCommand(splittedCommand);
                            break;

                        case "touch":
                            touch.touchCommand("", "");
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
