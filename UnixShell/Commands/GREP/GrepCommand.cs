namespace UnixShell.Commands.GREP
{
    public class GrepCommand
    {
        public void grepCommand(string path, string fileName, string subStr)
        {
            IEnumerable<string> linesFile = File.ReadLines(Path.Combine(path, fileName));

            foreach(string line in linesFile)
            {
                if (line.Contains(subStr))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
