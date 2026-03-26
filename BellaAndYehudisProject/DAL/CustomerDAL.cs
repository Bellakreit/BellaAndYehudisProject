using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private static readonly CustomerDAL _instance = new CustomerDAL();
        private List<Customer> _customers;
        private CustomerDAL()
        {
            _customers = new List<Customer>();
            InitializeList();

        }
        public static CustomerDAL Instance => _instance;


        public void InitializeList()
        {
            StreamReader reader = new StreamReader(@"..\..\..\DAL\CustomersFile.txt"); //reading values from text file
            ///read from text file
            ///take text file info and make into new products
            using (reader)
            {
                while (true)
                {
                    string numberline = reader.ReadLine();
                    if (numberline == null)
                        break;
                    string custname = reader.ReadLine();
                    string custid = reader.ReadLine();
                    string CCowner = reader.ReadLine();
                    string CCnumber = reader.ReadLine();
                    string CCexpDate = reader.ReadLine();
                    string CCsecurityCode = reader.ReadLine();
                    _customers.Add(new Customer(custname, custid, new CreditCard(CCowner, CCnumber, CCexpDate, CCsecurityCode)));
                }


            }


        }

        public void Create(Customer tmp)
        {
            //always make a copy of the object received as a parameter
            //check to see if that id already exists in the list
            //add new Person to list.
            //use List method .Add( ) 
            foreach (Customer customer in _customers) //loop through products to see if the ID already exists
            {
                if (tmp.ID == customer.ID)  // if product already exists throw exception
                {
                    throw
                        new ExceptionProductExists();
                }
            }
            Customer newCustomer = new Customer(tmp.Name, tmp.ID, tmp.creditCard);
            _customers.Add(newCustomer);
        }

        #region Read all the list
        //method to return the entire list

        public List<Customer> Read()
        {
            //make a copy of the list and return the list copy
            //there are 2 ways to do this.
            //Option one: go thru the original list, and for each Product, make a copy of the object,
            //            and add the copy to a new list that you have initialized.
            //             return the new list

            List<Customer> newCustomerList = _customers.Select(customer => new Customer(customer.Name, customer.ID, customer.creditCard)).ToList();

            return newCustomerList;
            #endregion

        }
    }
}