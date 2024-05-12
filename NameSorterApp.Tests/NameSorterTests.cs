using System;
using System.Collections.Generic;
using Xunit;

namespace NameSorterApp.Tests
{
    public class NameSorterTests
    {
        [Fact]
        public void SortNamesByLastNameReturnsSortedNames()
        {
            List<string> unsortedNames = new List<string> { "Beau Tristan Bentley", "Marin Alvarez", "Adonis Julius Archer" };
            List<string> expectedSortedNames = new List<string> { "Marin Alvarez", "Adonis Julius Archer", "Beau Tristan Bentley" };

            List<string> actualSortedNames = NameSorter.SortNamesByLastName(unsortedNames);

            Assert.Equal(expectedSortedNames, actualSortedNames);
        }

    }
}
