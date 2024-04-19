using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class NameSorter
{
    public static void Main(string[] args)
    {
        // checks if exactly one arguement has been provided (the unsorted names file), includes an error message and exits applications if there isnt only one and if there is
        // then it stores it for later use
        if (args.Length != 1)
        {
            Console.WriteLine("Error: please provide a file name in the command line");
            return;
        }

        string unsortedFileName = args[0];
        string sortedFileName = "sorted-names-list.txt";

    }
}