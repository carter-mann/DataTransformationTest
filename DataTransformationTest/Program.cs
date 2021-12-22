using System;
using System.IO;

namespace DataTransformationTest
{
    class Program
    {
        public static readonly string inputFileFolder = "C:\\Temp\\Data\\";

        static void Main(string[] args)
        {
            string inputFile = inputFileFolder + "SampleInputFile.txt";
            if (File.Exists(inputFile)) {
                var inputText = File.ReadAllText(inputFile);
                Console.WriteLine(inputText);
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            } else
            {
                Console.WriteLine("File read unsuccessful.");
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
