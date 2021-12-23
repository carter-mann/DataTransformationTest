using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformationTest.Models
{
    class ParserException : Exception
    {
        public string errorMessage;
        public ParserException(string message)
        {
            errorMessage = message;
        }

        public override string Message
        {
            get
            {
                return errorMessage;
            }
        }
    }
}
