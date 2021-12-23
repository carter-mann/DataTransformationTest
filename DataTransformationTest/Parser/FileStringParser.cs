using DataTransformationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.Parser
{
    class FileStringParser
    {
        private PersonStringListParser _personStringListParser;
        public FileStringParser()
        {
            _personStringListParser = new PersonStringListParser();
        }

        public string Parse(string input)
        {
            // Split file into people
            string[] inputLines = input.Split('\n');
            List<Person> people = new List<Person>();
            List<Dictionary<string, string>> peopleData = new List<Dictionary<string, string>>();
            Dictionary<string, string> tempPersonData = new Dictionary<string, string>();
            bool hasName = false;
            bool hasAge = false;
            bool hasCity = false;
            bool hasFlags = false;
            bool buildingPerson = true;
            foreach (string line in inputLines) {
                Console.WriteLine(line);
                if (line.StartsWith('(') && line.Contains(')'))
                {
                    Console.WriteLine("new line " + buildingPerson);
                    if (buildingPerson == false)
                    {
                        buildingPerson = true;
                    }
                        string[] lineToParse = line.Split(')');
                        string key = lineToParse[0].Substring(1);
                        string value = lineToParse[1];
                        switch (key)
                        {
                            case "Name":
                                hasName = true;
                                break;
                            case "Age":
                                hasAge = true;
                                break;
                            case "City":
                                hasCity = true;
                                break;
                            case "Flags":
                                hasFlags = true;
                                break;
                            default:
                                throw new ParserException("Invalid key");
                        }
                        tempPersonData.Add(key, value);
                }
                else
                {
                    if (hasName && hasCity && hasFlags)
                    {
                        peopleData.Add(tempPersonData);
                        tempPersonData.Clear();
                        hasName = false;
                        hasAge = false;
                        hasCity = false;
                        hasFlags = false;
                        buildingPerson = false;
                        Console.WriteLine("person built");
                    } else if (!buildingPerson)
                    {
                        continue;
                    } else
                    {
                        Console.WriteLine(hasName.ToString() + hasCity.ToString() + hasFlags.ToString());
                        throw new ParserException("Invalid Values for Person");
                    }
                }
            }

            foreach (Dictionary<string, string> personData in peopleData)
            {
                //convert to person
                Person person = _personStringListParser.ParseStringListToPerson(personData);
                people.Add(person);
            }

            //convert people to output format
            StringBuilder output = new StringBuilder();
            foreach (Person p in people)
            {
                output.Append(p.ToString()).AppendLine();
            }
            return output.ToString();
        }
    }
}
