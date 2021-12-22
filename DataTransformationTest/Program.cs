using DataTransformationTest.FileRead;
using System;
using System.IO;

namespace DataTransformationTest
{
    class Program
    {

        static void Main(string[] args)
        {
            TextFileReader inputFileReader = new TextFileReader();
            string inputText = inputFileReader.ReadInputFileToString();
            if (inputText != null) {
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
