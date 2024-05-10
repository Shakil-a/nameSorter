using System.Collections.Generic;

namespace NameSorterApp
{
    public class Sorter
    {
        public List<string> SortNames(List<string> names)
        {
            return NameSorter.SortNamesByLastName(names);
        }
    }
}
