using System;


namespace UnixShell.Commands.ECHO
{
    public class EchoCommand
    {
        public void echoCommand(string[] splittedCommand)
        {
            if (splittedCommand.Length > 1)
            {
                Console.WriteLine(String.Join(" ", splittedCommand, 1, splittedCommand.Length - 1));
            }
        }
    }
}
