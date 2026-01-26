using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //this class initializes a cutomer that is a person and stores their crdit card in a constructor with the person 
    internal class Customer
        :Person
    {
        public CreditCard creditCard{ get; set; } //to hav ethe credit card details 
        /// <summary>
        /// returns ctor with details abt a costumer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="creditCard"></param>
        public Customer(string name, string id, CreditCard creditCard)
            :base(name, id)
        {
            this.creditCard = creditCard;
        }
    }
}
