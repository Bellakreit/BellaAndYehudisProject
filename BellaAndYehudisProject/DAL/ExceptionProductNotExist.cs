using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionProductNotExist
        :Exception
    {
        public ExceptionProductNotExist() : base("This product number does not exist")
        {

        }

        public ExceptionProductNotExist(string message) : base(message)
        {

        }

        public ExceptionProductNotExist(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

