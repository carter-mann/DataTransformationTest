using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.FileRead
{
    class TextFileReader
    {
        public static readonly string inputFileFolder = "C:\\Temp\\Data\\";
        public static readonly string defaultInputFileName = "SampleInputFile.txt";

        public string ReadInputFileToString()
        {
            string inputFile = inputFileFolder + defaultInputFileName;
            if (File.Exists(inputFile))
            {
                return File.ReadAllText(inputFile);
            }
            return null;
        }
    }
}
