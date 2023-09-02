using UnixShell.Commands.LS;
using UnixShell.Commands.PWD;

public class Program
{
    public static void Main(string[] args)
    {
        /*
           =============================================================
           =============================================================
            Unix Shell
            
            [ ] The program should start in the current directory where you
            execute it from.
            
            Functionalities:
            [ ] pwd
            [X] ls
            [ ] cd
            [ ] cp
            [ ] mv
            [ ] rm
            [ ] mkdir
            [ ] echo
            [ ] touch
            [ ] cat
            [ ] grep
            [ ] pipes
            
            The program should act like a normal shell where you run commands.
            
           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");


        //LsCommand lsCMD = new LsCommand();
        //string output = lsCMD.lsCommand(@"");
        //Console.WriteLine(output);


        //PwdCommand pwdCMD = new PwdCommand();
        //Console.WriteLine(pwdCMD.pwdCommand());

        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}