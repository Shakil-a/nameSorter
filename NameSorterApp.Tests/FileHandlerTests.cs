using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace NameSorterApp.Tests
{
    public class FileHandlerTests
    {
        [Fact]
        public void ReadLinesReturnsCorrectLines()
        {
            string testFileName = "test-file.txt";
            List<string> expectedLines = new List<string> { "Line 1", "Line 2", "Line 3" };
            File.WriteAllLines(testFileName, expectedLines);

            List<string> actualLines = FileHandler.ReadLines(testFileName);

            Assert.Equal(expectedLines, actualLines);
            File.Delete(testFileName);
        }

        [Fact]
        public void WriteLinesWritesLinesToFile()
        {
            string testFileName = "test-file.txt";
            List<string> linesToWrite = new List<string> { "Line 1", "Line 2", "Line 3" };

            FileHandler.WriteLines(testFileName, linesToWrite);

            Assert.True(File.Exists(testFileName));
            string[] actualLines = File.ReadAllLines(testFileName);
            Assert.Equal(linesToWrite, actualLines);
            File.Delete(testFileName);
        }
    }
}
