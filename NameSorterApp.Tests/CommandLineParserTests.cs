using System;
using Xunit;

namespace NameSorterApp.Tests
{
    /// <summary>
    /// Contains unit tests for the CommandLineParser class.
    /// </summary>
    public class CommandLineParserTests
    {
        [Fact]
        public void ParseFileNameReturnsFileName()
        {
            var parser = new CommandLineParser();
            string[] args = new string[] { "input.txt" };
            string expectedFileName = "input.txt";

            string actualFileName = parser.ParseFileName(args);

            Assert.Equal(expectedFileName, actualFileName);
        }
    }
}
