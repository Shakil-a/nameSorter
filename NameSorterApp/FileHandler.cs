using System.Collections.Generic;
using System.IO;

namespace NameSorterApp
{
    /// <summary>
    /// Responsible for reading lines and writing lines to a file.
    /// </summary>
    public class FileHandler
    {
        public static List<string> ReadLines(string fileName)
        {
            return new List<string>(File.ReadAllLines(fileName));
        }

        public static void WriteLines(string fileName, List<string> lines)
        {
            File.WriteAllLines(fileName, lines);
        }
    }
}
