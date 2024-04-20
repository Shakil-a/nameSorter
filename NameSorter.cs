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
        List<string> unsortedNames = ReadNamesFromFile(unsortedFileName);
        List<string> sortedNames = SortNamesByLastName(unsortedNames);

        // Print sorted names to consolw and write to output file
        PrintAndWriteSortedNames(sortedNames, sortedFileName);

    }

    private static List<string> ReadNamesFromFile(string fileName)
    {
        return File.ReadAllLines(fileName).ToList();
    }

    private static string GetLastName(string fullName)
    {
        int lastSpacePosition = fullName.LastIndexOf(' ');
        string lastName = fullName.Substring(lastSpacePosition + 1);
        return lastName;
    }

    private static string GetOtherNames(string fullName)
    {
        int lastSpacePosition = fullName.LastIndexOf(' ');
        string otherNames = fullName.Substring(0, lastSpacePosition);
        return otherNames;
    }

    private static List<string> SortNamesByLastName(List<string> names)
    {
        return names.OrderBy(name => GetLastName(name)).ThenBy(name => GetOtherNames(name)).ToList();
    }

    private static void PrintAndWriteSortedNames(List<string> names, string fileName)
    {
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        File.WriteAllLines(fileName, names);
    }
}