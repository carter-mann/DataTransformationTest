using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.Models
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool isFemale { get; set; }
        public bool isStudent { get; set; }
        public bool isEmployee { get; set; }

        public override string ToString()
        {
            StringBuilder outputBuilder = new StringBuilder();

            // Build the output line-by-line
            outputBuilder.Append(FirstName)
                .Append(' ')
                .Append(LastName)
                .Append(isFemale ? "Female" : "Male")
                .AppendLine();

            return outputBuilder.ToString();
        }
    }
}
