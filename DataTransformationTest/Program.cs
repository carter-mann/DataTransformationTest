using DataTransformationTest.FileRead;
using DataTransformationTest.StringParser;
using System;
using System.IO;

namespace DataTransformationTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Reading Input File...");
            TextFileReader inputFileReader = new TextFileReader();
            PersonStringParser parser = new PersonStringParser();
            string inputText = inputFileReader.ReadInputFileToString();
            if (inputText != null)
            {
                Console.WriteLine("File Read Successful.");
                Console.WriteLine("Beginning Parse of Contents...");
                string parserOutput = parser.Parse(inputText);
                Console.WriteLine("Parser Output:");
                Console.WriteLine(parserOutput);
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
