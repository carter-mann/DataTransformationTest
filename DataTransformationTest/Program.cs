using DataTransformationTest.FileRead;
using DataTransformationTest.Parser;
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
            FileStringParser parser = new FileStringParser();

            try
            {
                string inputText = inputFileReader.ReadInputFileToString();
                Console.WriteLine("File Read Successful.");
                Console.WriteLine("Beginning Parse of Contents...");
                string parserOutput = parser.Parse(inputText);
                Console.WriteLine("Parser Output:");
                Console.WriteLine(parserOutput);
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            } catch (Exception ex)
            {
                Console.WriteLine("Invalid data, unable to process.");
                Console.WriteLine(ex.Message);
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
