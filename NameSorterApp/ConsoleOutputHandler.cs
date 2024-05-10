using System;
using System.Collections.Generic;

namespace NameSorterApp
{
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
