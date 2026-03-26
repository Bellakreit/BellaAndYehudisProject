using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class CustomerBL
    {
            public CustomerDAL cd1;  //instance variable of type customerdal

            public CustomerBL(CustomerDAL customer)   //ctor 
            {
                this.cd1 = customer;
            }

            public void CreateCustomer(Customer temp) //create customer
            {
                try
                {
                    cd1.Create(temp);
                }
                catch (ExceptionCustomerExists ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
            public List<Customer> Read() //read all customers
            {
                return cd1.Read();
            }
            public Customer Read(string id) //read one customer
            {
                try
                {
                    return cd1.Read(id);
            }
                catch (ExceptionCustomerNotExist ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }
            }

            public void UpdateCustomer(Customer temp)  //update Customer
            {
                try
                {
                    cd1.Update(temp);
                }
                catch (ExceptionCustomerNotExist ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }

            public void DeleteCustomer(Customer temp)    //delete Customer
        {
                try
                {
                    cd1.Delete(temp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }

        }
    }
