using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Error: please provide a file name in the command line");
                return;
            }

            string unsortedFileName = args[0];
            string sortedFileName = "sorted-names-list.txt";

            List<string> unsortedNames = FileHandler.ReadLines(unsortedFileName);
            List<string> sortedNames = NameSorter.SortNamesByLastName(unsortedNames);

            PrintAndWriteSortedNames(sortedNames, sortedFileName);
        }

        private static void PrintAndWriteSortedNames(List<string> names, string fileName)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            FileHandler.WriteLines(fileName, names);
        }
    }
}
