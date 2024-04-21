using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorterApp
{
    public class NameSorter
    {    
        /// <summary>
        /// Main method to execute the nameSorter solution
        /// </summary>
        /// <param name="args">Expecting a unsorted file name as a command line argument</param>
        public static void Main(string[] args)
        {
            // Check if input file argument is provided
            if (args.Length != 1)
            {
                Console.WriteLine("Error: please provide a file name in the command line");
                return;
            }

            // Store input and output file names
            string unsortedFileName = args[0];
            string sortedFileName = "sorted-names-list.txt";

            // Read unsorted names from file and sort by last name alphabetically
            List<string> unsortedNames = ReadNamesFromFile(unsortedFileName);
            List<string> sortedNames = SortNamesByLastName(unsortedNames);

            // Print sorted names to console and write to output file
            PrintAndWriteSortedNames(sortedNames, sortedFileName);
        }
     
        /// <summary>
        /// Reads names from a file and returns them as a list of strings
        /// </summary>
        /// <param name="fileName">The name of the input file</param>
        /// <returns>A list of names from the input file</returns>
        public static List<string> ReadNamesFromFile(string fileName)
        {
            return File.ReadAllLines(fileName).ToList();
        }
    
        /// <summary>
        /// Retrieves the last name from a full name
        /// </summary>
        /// <param name="fullName">The full Name</param>
        /// <returns>Last Name extracted from the full name</returns>
        public static string GetLastName(string fullName)
        {
            int lastSpacePosition = fullName.LastIndexOf(' ');
            string lastName = fullName.Substring(lastSpacePosition + 1);
            return lastName;
        }
    
        /// <summary>
        /// Retrieves the given names from a full name
        /// </summary>
        /// <param name="fullName">The full name</param>
        /// <returns>Given names extracted from full name</returns>
        public static string GetGivenNames(string fullName)
        {
            int lastSpacePosition = fullName.LastIndexOf(' ');
            string givenNames = fullName.Substring(0, lastSpacePosition);
            return givenNames;
        }
    
        /// <summary>
        /// Sorts a list of names by last name, then by given names.
        /// </summary>
        /// <param name="names">List of names to be sorted</param>
        /// <returns>Sorted list of names</returns>
        public static List<string> SortNamesByLastName(List<string> names)
        {
            return names.OrderBy(name => GetLastName(name)).ThenBy(name => GetGivenNames(name)).ToList();
        }
    
        /// <summary>
        /// Prints the sorted names to the console and writes them to the sorted output file.
        /// </summary>
        /// <param name="names">Sorted List of names</param>
        /// <param name="fileName">Name of the sorted output file</param>
        public static void PrintAndWriteSortedNames(List<string> names, string fileName)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            File.WriteAllLines(fileName, names);
        }
    }
}
