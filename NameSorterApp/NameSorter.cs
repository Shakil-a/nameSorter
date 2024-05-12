using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorterApp
{
    /// <summary>
    /// Responsible for sorting names based on last name and given names.
    /// </summary>
    public class NameSorter
    {
        public static List<string> SortNamesByLastName(List<string> names)
        {
            return names.OrderBy(name => GetLastName(name)).ThenBy(name => GetGivenNames(name)).ToList();
        }

        private static string GetLastName(string fullName)
        {
            int lastSpacePosition = fullName.LastIndexOf(' ');
            return fullName.Substring(lastSpacePosition + 1);
        }

        private static string GetGivenNames(string fullName)
        {
            int lastSpacePosition = fullName.LastIndexOf(' ');
            return fullName.Substring(0, lastSpacePosition);
        }
    }
}
