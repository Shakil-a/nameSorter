using System;

namespace NameSorterApp
{
    /// <summary>
    /// Responsible for parsing command-line arguments to extract the file name.
    /// </summary>
    public class CommandLineParser
    {
        public string ParseFileName(string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("Error: Please provide a single file name as a command-line argument.");
            }

            return args[0];
        }
    }
}
