using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace NameSorterApp.Tests
{
    public class NameSorterTests
    {
        // Test method to verify if ReadNamesFromFile reads names correctly
        [Fact]
        public void ReadNamesFromFileTest()
        {
            // create a test file with expected names
            string testFileName = "test-names.txt";
            List<string> expectedNames = new List<string>
            {
                "John Smith",
                "Alice Johnson",
                "Bob Johnson"
            };

            File.WriteAllLines(testFileName, expectedNames);

            //read the actual names from testfile and check it is equal to expected names
            List<string> actualNames = NameSorter.ReadNamesFromFile(testFileName);
            Assert.Equal(expectedNames, actualNames);

            //  delete the test file
            File.Delete(testFileName);
        }

    }
}
