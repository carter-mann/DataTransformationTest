using DataTransformationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.Parser
{
    class PersonStringListParser
    {
        public Person ParseStringListToPerson(Dictionary<string, string> personData)
        {
            Person p = new Person();
            string[] name = personData["Name"].Split(' ');
            p.FirstName = name[0];
            p.LastName = name[1];
            if (personData.ContainsKey("Age"))
            {
                p.Age = int.Parse(personData["Age"]);
            }
            string cityValue = personData["City"];
            if (cityValue.Contains(','))
            {
                string[] cityValues = cityValue.Split(", ");
                p.City = cityValues[0];
                p.State = cityValues[1];
            } else
            {
                p.City = cityValue;
            }
            char[] flags = personData["Flags"].ToCharArray();
            if (flags.Length != 3)
            {
                throw new ParserException("Invalid Flags");
            }
            p.isFemale = flags[0] == 'Y' ? true : false;
            p.isStudent = flags[0] == 'Y' ? true : false;
            p.isEmployee = flags[0] == 'Y' ? true : false;

            return p;
        }
    }
}
