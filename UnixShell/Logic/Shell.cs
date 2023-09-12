using UnixShell.Commands.CAT;
using UnixShell.Commands.CD;
using UnixShell.Commands.CP;
using UnixShell.Commands.ECHO;
using UnixShell.Commands.LS;
using UnixShell.Commands.MKDIR;
using UnixShell.Commands.MV;
using UnixShell.Commands.PWD;
using UnixShell.Commands.RM;
using UnixShell.Commands.TOUCH;
using System.Text.RegularExpressions;
using UnixShell.Commands.GREP;

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
        RmCommand rm = new RmCommand();
        GrepCommand grep = new GrepCommand();

        public void shell()
        {
            string path = homePath;

            while (true)
            {
                Console.Write(">> ");
                string command = userInput();

                if (!String.IsNullOrEmpty(command))
                {
                    string commandItem = "";

                    if (command.Contains("cd "))
                    {
                        if (command.Contains("cd .."))
                        {
                            commandItem = "cd ..";
                        }
                        else
                        {
                            commandItem = "cd";
                        }
                    }
                    else if (command.Contains("rm") && command.Contains("-rf"))
                    {
                        commandItem = "rm -rf";
                    }
                    else
                    {
                        commandItem = command.Split(" ")[0].Trim();
                    }

                    List<string> paramsCommandslist = matchParams(command);

                    switch (commandItem)
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
                            path = cd.cdCommand(path, paramsCommandslist[0]);
                            break;

                        case "cd ..":
                            path = cd.cdPreviousFolder(path);
                            break;

                        case "cp":
                            if (paramsCommandslist.Count == 2)
                            {
                                cp.cpCommand(path , paramsCommandslist[0], paramsCommandslist[1]);
                            }
                            break;

                        case "mv":
                            if (paramsCommandslist.Count == 2)
                            {
                                mv.mvCommand(path, paramsCommandslist[0], paramsCommandslist[1]);
                            }
                            break;

                        case "rm":
                            rm.rmCommand(false, path, paramsCommandslist[0]);
                            break;

                        case "rm -rf":
                            rm.rmCommand(true, path, paramsCommandslist[0]);

                            break;

                        case "mkdir":
                            if (paramsCommandslist.Count == 1)
                            {
                                mkdir.mkdirCommand(path, paramsCommandslist[0]);
                            }
                            break;

                        case "echo":
                            echo.echoCommand(paramsCommandslist.ToArray());
                            break;

                        case "touch":
                            touch.touchCommand(path, paramsCommandslist.ToArray());
                            break;

                        case "cat":
                            cat.catCommand(path, paramsCommandslist.ToArray());
                            break;

                        case "grep":
                            grep.grepCommand(path, paramsCommandslist[1], paramsCommandslist[0]);
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

        private List<string> matchParams(string input)
        {
            List<string> items = new List<string>();

            MatchCollection m = Regex.Matches(input, @"""(.*?)""");

            for (int i = 0; i < m.Count; i++)
            {
                items.Add(m[i].Groups[1].Value);
            }

            return items;
        }
    }
}
