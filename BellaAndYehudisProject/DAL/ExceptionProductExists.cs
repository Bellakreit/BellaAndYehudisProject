using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionProductExists
        : Exception
    {
        public ExceptionProductExists() : base("This product number already exists")
        {

        }

        public ExceptionProductExists(string message) : base(message)
        {

        }

        public ExceptionProductExists(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}