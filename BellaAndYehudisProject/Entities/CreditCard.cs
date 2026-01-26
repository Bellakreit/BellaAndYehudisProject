using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class CreditCard
    {   
        public int CreditCardNumber { get; set; } //the CC number
        public string CCOwner { get; set; } //Name on credit card
        public int ExpDate { get; set; } //experation date
        public int SecurityCode { get; set; } //security code
        /// <summary>
        /// Initialize all the elements within a credit card
        /// </summary>
        /// <param name="ccowner"></param>
        /// <param name="creditcardnumber"></param>
        /// <param name="expdate"></param>
        /// <param name="securitycode"></param>
        public CreditCard(string ccowner, int creditcardnumber, int expdate, int securitycode)
        {
            CCOwner = ccowner;
            CreditCardNumber = creditcardnumber;
            ExpDate = expdate;
            SecurityCode = securitycode;
        }

    }
}
