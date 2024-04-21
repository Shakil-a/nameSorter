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
            // Arrange
            string testFileName = "test-names.txt";
            List<string> expectedNames = new List<string> { "John Smith", "Alice Johnson", "Bob Johnson" };

            // Act
            File.WriteAllLines(testFileName, expectedNames);
            List<string> actualNames = NameSorter.ReadNamesFromFile(testFileName);

            // Assert
            Assert.Equal(expectedNames, actualNames);
            File.Delete(testFileName); // Clean up
        }

        // Test method to verify if GetLastName correctly extracts last name from full name
        [Fact]
        public void GetLastNameTest()
        {
            // Arrange
            string fullName = "John Smith";
            string expectedLastName = "Smith";

            // Act
            string actualLastName = NameSorter.GetLastName(fullName);

            // Assert
            Assert.Equal(expectedLastName, actualLastName);
        }

        // Test method to verify if GetGivenNames correctly extracts given names from full name
        [Fact]
        public void GetGivenNamesTest()
        {
            // Arrange
            string fullName = "John Smith";
            string expectedGivenNames = "John";

            // Act
            string actualGivenNames = NameSorter.GetGivenNames(fullName);

            // Assert
            Assert.Equal(expectedGivenNames, actualGivenNames);
        }

        // Test method to verify if PrintAndWriteSortedNames writes names to file correctly
        [Fact]
        public void PrintAndWriteSortedNamesTest()
        {
            // Arrange
            List<string> names = new List<string> { "Alice Johnson", "Bob Smith", "John Doe" };
            string testFileName = "test-output.txt";

            // Act
            NameSorter.PrintAndWriteSortedNames(names, testFileName);

            // Assert
            Assert.True(File.Exists(testFileName));
            string[] lines = File.ReadAllLines(testFileName);
            Assert.Equal(names.Count, lines.Length);
            Assert.Equal(names, lines);
            File.Delete(testFileName); 
        }
    }
}
