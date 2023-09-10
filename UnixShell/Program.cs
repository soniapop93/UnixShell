using UnixShell.Commands.LS;
using UnixShell.Commands.PWD;
using UnixShell.Logic;

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
            [X] pwd
            [X] ls
            [X] cd
            [X] cp
            [X] mv
            [X] rm
            [X] mkdir
            [X] echo
            [X] touch
            [X] cat
            [ ] grep
            [ ] pipes
            
            The program should act like a normal shell where you run commands.
            
           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");

        Shell sh = new Shell();
        //sh.shell();

        sh.matchParams("mkdir \"testing\" \"test\"");

        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}