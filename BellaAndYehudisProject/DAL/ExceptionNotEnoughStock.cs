using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionNotEnoughStock : Exception
    {
        public ExceptionNotEnoughStock() : base("There is not enough of this in stock!")
        {

        }
        public ExceptionNotEnoughStock(string message) : base(message)
        {

        }
        public ExceptionNotEnoughStock(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
