using System.Collections.Generic;

namespace NameSorterApp
{
    /// <summary>
    ///  a sorter for sorting names by their lastname
    /// </summary>
    public class Sorter
    {
        public List<string> SortNames(List<string> names)
        {
            return NameSorter.SortNamesByLastName(names);
        }
    }
}
