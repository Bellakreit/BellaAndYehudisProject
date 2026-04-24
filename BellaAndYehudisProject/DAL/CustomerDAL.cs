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
            ///take text file info and make into new customers
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

        #region Create
        public void Create(Customer tmp)
        {
            //always make a copy of the object received as a parameter
            //check to see if that id already exists in the list
            //add new Customer to list.
            //use List method .Add( ) 
            foreach (Customer customer in _customers) //loop through products to see if the ID already exists
            {
                if (tmp.ID == customer.ID)  // if customer already exists throw exception
                {
                    throw
                        new ExceptionCustomerExists();
                }
            }
            Customer newCustomer = new Customer(tmp.Name, tmp.ID, tmp.creditCard);
            _customers.Add(newCustomer);
        }
        #endregion

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
        }
        #endregion

        #region Read one Customer
        //method to return one Customer according to ID

        public Customer Read(string id)
        {

            //loop thru list checking to see if current Customer ojbect's id matches
            // id of parameter
            //when matching id is found, return the Customer copy

            foreach (Customer customer in _customers) //loop through customer to see if the ID already exists
            {
                if (id == customer.ID)
                {
                    return new Customer(customer.Name, customer.ID, customer.creditCard);
                }
            }
            // if you reach this - the customer does not exist - throw exception
            throw
                new ExceptionCustomerNotExist();
        }
        #endregion

        #region Update
        //method Update to change some values of a Customer

        public void Update(Customer tmp)
        {
            bool Customerexist = false; // is there such a Customer?
            //go thru list to find Customer whose id matches the id of Customer parameter
            foreach (Customer customer in _customers) //loop through Customers to see if the ID already exists
            {
                if (tmp.ID == customer.ID)
                {
                    Customerexist = true;
                    //change the values of Customer object in list to match the values of Customer parameter
                    customer.ID = tmp.ID;
                    customer.Name = tmp.Name;
                    customer.creditCard = tmp.creditCard;
                }
            }
            // if the Customer does not exist throw an exception
            if (Customerexist == false)
            {
                throw new ExceptionCustomerNotExist();
            }
        }
        #endregion

        #region Delete
        // method to Delete a Customer from the list

        public void Delete(Customer tmp)
        {
            //try
            //{
            bool Customerexist = false;
            //go thru list to find Customer whose id matches the id of Customer parameter
            //delete that Customer from the list
            //use List method Remove
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].ID == tmp.ID)
                {
                    Customerexist = true;
                    _customers.Remove(_customers[i]);
                    break;
                }

            }
            if (Customerexist == false)
            {
                throw new ExceptionCustomerNotExist();
            }
        }
    
    }
    #endregion

}
