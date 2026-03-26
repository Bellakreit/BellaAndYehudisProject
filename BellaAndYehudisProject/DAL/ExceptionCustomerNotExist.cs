using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionCustomerNotExist
                : Exception
    {
        public ExceptionCustomerNotExist() : base("This customer does not exist")
        {

        }

        public ExceptionCustomerNotExist(string message) : base(message)
        {

        }

        public ExceptionCustomerNotExist(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
