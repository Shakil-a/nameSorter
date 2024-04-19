using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class NameSorter
{
    public static void Main(string[] args)
    {
        // checks if exactly one arguement has been provided (the unsorted names file), includes an error message and exits applications if there isnt only one 
        // and if there is then it stores it for later use
        if (args.Length != 1)
        {
            Console.WriteLine("Error: please provide a file name in the command line");
            return;
        }

        string unsortedFileName = args[0];
        //string sortedFileName = "sorted-names-list.txt";

        // retrive unsorted names from unsorted file and sort them alphabetically by last name, test if it had worked in console
        List<string> unsortedNames = File.ReadAllLines(unsortedFileName).ToList();
        List<string> sortedNames = unsortedNames.OrderBy(name => {
            int lastSpacePosition = name.LastIndexOf(' ');
            string lastName = name.Substring(lastSpacePosition + 1);
            return lastName;
        } ).ToList();

          foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }


    }
}