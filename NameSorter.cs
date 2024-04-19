using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class NameSorter
{
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
        List<string> unsortedNames = File.ReadAllLines(unsortedFileName).ToList();
        List<string> sortedNames = unsortedNames.OrderBy(name => {
            int lastSpacePosition = name.LastIndexOf(' ');
            string lastName = name.Substring(lastSpacePosition + 1);
            string OtherNames = name.Substring(0, lastSpacePosition);
            return lastName + " " + OtherNames;
        } ).ToList();

        // Print sorted names to consolw and write to output file
        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }

        File.WriteAllLines(sortedFileName, sortedNames);

    }
}