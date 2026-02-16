using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ExceptionPrdocutNotExist
        :Exception
    {
        public ExceptionPrdocutNotExist() : base("This product number does not exists")
        {

        }

        public ExceptionPrdocutNotExist(string message) : base(message)
        {

        }

        public ExceptionPrdocutNotExist(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

