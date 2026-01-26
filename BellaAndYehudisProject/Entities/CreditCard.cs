//Class for initalizing a credit card
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CreditCard
    {   
        public string CreditCardNumber { get; set; } //the CC number
        public string CCOwner { get; set; } //Name on credit card
        public string ExpDate { get; set; } //experation date
        public string SecurityCode { get; set; } //security code
        /// <summary>
        /// Initialize all the elements within a credit card
        /// </summary>
        /// <param name="ccowner"></param>
        /// <param name="creditcardnumber"></param>
        /// <param name="expdate"></param>
        /// <param name="securitycode"></param>
        public CreditCard(string ccowner, string creditcardnumber, string expdate, string securitycode)
        {
            CCOwner = ccowner;
            CreditCardNumber = creditcardnumber;
            ExpDate = expdate;
            SecurityCode = securitycode;
        }

        /// <summary>
        /// returns tostring fot Credit card
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Credit Card holder: " + CCOwner + "Credit Card Number: " + CreditCardNumber + "Exp Date: " + ExpDate + "Security Code: " + SecurityCode;
        }

    }
}
