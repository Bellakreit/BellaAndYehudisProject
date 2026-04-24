using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionOrderNotExist: Exception
    {
        public ExceptionOrderNotExist() : base("This order does not exist")
        {
             
        }
        public ExceptionOrderNotExist(string message): base(message) 
        {
             
        }
        public ExceptionOrderNotExist(string message, Exception innerException) : base(message, innerException)
        {
             
        }
    }
}
