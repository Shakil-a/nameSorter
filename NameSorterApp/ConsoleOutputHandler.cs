using System;
using System.Collections.Generic;

namespace NameSorterApp
{
    /// <summary>
    /// Responsible for printing sorted names to the console.
    /// </summary>
    public class ConsoleOutputHandler
    {
        public void PrintSortedNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
