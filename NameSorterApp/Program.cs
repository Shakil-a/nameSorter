using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    /// <summary>
    /// The entry of the NameSorterApp application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CommandLineParser parser = new CommandLineParser();
                Sorter sorter = new Sorter();
                ConsoleOutputHandler outputHandler = new ConsoleOutputHandler();

                string unsortedFileName = parser.ParseFileName(args);
                string sortedFileName = "sorted-names-list.txt";

                List<string> unsortedNames = FileHandler.ReadLines(unsortedFileName);
                List<string> sortedNames = sorter.SortNames(unsortedNames);

                outputHandler.PrintSortedNames(sortedNames);

                FileHandler.WriteLines(sortedFileName, sortedNames);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
