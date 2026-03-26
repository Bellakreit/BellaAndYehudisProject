using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionCustomerExists
          : Exception
    {
        public ExceptionCustomerExists() : base("This customer already exists")
        {

        }

        public ExceptionCustomerExists(string message) : base(message)
        {

        }

        public ExceptionCustomerExists(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
