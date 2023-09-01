using UnixShell.Commands.LS;

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
            [ ] ls
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


        LsCommand lsCMD = new LsCommand();
        string output = lsCMD.lsCommand(@"");

        Console.WriteLine(output);

        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}