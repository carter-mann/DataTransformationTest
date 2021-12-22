using DataTransformationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.StringParser
{
    class PersonStringParser
    {
        public string Parse(string input)
        {
            // Split file into people
            string[] inputLines = input.Split('\n');
            List<Person> people = new List<Person>();
            List<List<string>> peopleData = new List<List<string>>();
            List<string> tempPersonData = new List<string>();
            foreach (string line in inputLines) {
                if (line.StartsWith('('))
                {
                    tempPersonData.Add(line);
                }
                else
                {
                    peopleData.Add(tempPersonData);
                    tempPersonData.Clear();
                }
            }

            foreach (List<string> personData in peopleData)
            {
                //convert to person
            }

            //convert people to output format
            return "Hello";
        }
    }
}
