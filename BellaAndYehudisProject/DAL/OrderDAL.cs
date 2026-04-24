using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDAL
    {
        private static readonly OrderDAL _instance = new OrderDAL();
        private List<Order> _orders;
        private ProductDAL _productDAL = ProductDAL.Instance;
        private CustomerDAL _customerDAL = CustomerDAL.Instance;

        public OrderDAL()
        {
            _orders = new List<Order>();
            InitializeList();
        }

        public static OrderDAL Instance => _instance;

        public void InitializeList()
        {
            StreamReader reader = new StreamReader(@"..\..\..\DAL\OrdersFile.txt"); //reading values from text file
            using (reader)
            {
                while (true)
                {
                    string numberline = reader.ReadLine();
                    if (numberline == null)
                        break;
                    int productnumber = int.Parse(reader.ReadLine());
                    string customerid = reader.ReadLine();
                    int orderquantity = int.Parse(reader.ReadLine());
                    _orders.Add(new Order(productnumber, customerid, orderquantity));

                }
            }
        }

        #region Create
        public void Create(Order tmp)
        {
            bool ValidCustomer = false;  //variables to make sure the product number and customer id exist
            bool ValidProduct = false;
            List<Customer> custs = _customerDAL.Read();  //getting the list of customers
            foreach (Customer customer in custs)   //checking to make sure the customer id for the order matches one in the list
                if (tmp.CustomerID == customer.ID)
                {
                   ValidCustomer = true;  //if so customer becomes valid so true
                }
            List<Product> prods = _productDAL.Read();  //getting the list of products
            foreach (Product product in prods)   ///checking to make sure the product id for the order matches one in the list
            {
                if (tmp.ProductNumber == product.ProductNumber)
                {
                    ValidProduct = true;  //if so product is valid
                }
            }
            if (ValidCustomer && ValidProduct)  //if both costumer and product are valid then do create
            {
                Order order = new Order(tmp.ProductNumber, tmp.CustomerID, tmp.OrderQuantity);
                _orders.Add(order);
            }
            else if (ValidProduct) //if product is true that means the customer is not valid
            {
                throw new ExceptionCustomerNotExist();
            }
            else 
            {
                throw new ExceptionProductNotExist();
            }
        }
        #endregion

        #region Read all the list
        //method to return the entire list

        public List<Order> Read()
        {
            //make a copy of the list and return the list copy
            //there are 2 ways to do this.
            //Option one: go thru the original list, and for each order, make a copy of the object,
            //            and add the copy to a new list that you have initialized.
            //             return the new list

            List<Order> newOrderList = _orders.Select(order => new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity)).ToList();

            return newOrderList;
        }
        #endregion

        #region Read  by order
        //method to return one order according to ID

        public Order Read(int id)
        {

            //loop thru list checking to see if currentorder ojbect's id matches
            // id of parameter
            //when matching id is found, return the order copy

            foreach (Order order in _orders) //loop through orders to see if the ID already exists
            {
                if (id == order.OrderNumber)
                {
                    return new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity);
                }
            }
            // if you reach this - the order does not exist - throw exception
            throw
                new ExceptionOrderNotExist();
        }
        #endregion

        #region Read by Product
        public Order ReadbyProduct(int productnumber)
        {
            //loop thru list checking to see if currentorder ojbect's product number matches
            // productnumber of parameter
            //when matching product number is found, return the order copy

            foreach (Order order in _orders) //loop through orders to see if the Product number already exists
            {
                if (productnumber == order.ProductNumber)  //if match then return it
                {
                    return new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity);
                }
            }
            // if you reach this - the order does not exist - throw exception
            throw
                new ExceptionOrderNotExist();

        }
        #endregion

        #region Read by Customer
        public Order ReadbyCustomer(string customerID)
        {
            //loop thru list checking to see if currentorder ojbect's product number matches
            // productnumber of parameter
            //when matching product number is found, return the order copy

            foreach (Order order in _orders) //loop through orders to see if the Product number already exists
            {
                if (customerID == order.CustomerID)  //if match then return it
                {
                    return new Order(order.ProductNumber, order.CustomerID, order.OrderQuantity);
                }
            }
            // if you reach this - the order does not exist - throw exception
            throw
                new ExceptionOrderNotExist();
        }
        #endregion

        #region Update
        //method Update to change some values of a order

        public void Update(Order tmp)
        {
            bool Orderexist = false; // is there such an order?
            //go thru list to find order whose id matches the id of order parameter
            bool ValidCustomer = false;
            bool ValidProduct = false;
            foreach (Order order in _orders) //loop through orders to see if the ID already exists and we can change the customer and oroduct IDs to match
            {
                if (tmp.OrderNumber == order.OrderNumber)
                {
                    Orderexist = true;
                    // now make sure it is valid to switch the customer and products IDs
                    List<Customer> custs = _customerDAL.Read();
                    foreach (Customer customer in custs)   //checking to make sure the new customer id for the order matches one in the list
                        if (tmp.CustomerID == customer.ID)
                        {
                            ValidCustomer = true;  //if so customer becomes valid so true
                        }
                    List<Product> prods = _productDAL.Read();  //getting the list of products
                    foreach (Product product in prods)   ///checking to make sure the product id for the order matches one in the list
                    {
                        if (tmp.ProductNumber == product.ProductNumber)
                        {
                            ValidProduct = true;  //if so product is valid
                        }
                    }
                    if (ValidCustomer && ValidProduct)  //if both costumer and product are valid then do create
                    {
                        //change the values of order object in list to match the values of order parameter
                        order.ProductNumber = tmp.ProductNumber;
                        order.CustomerID = tmp.CustomerID;
                        order.OrderQuantity = tmp.OrderQuantity;
                    }

                }
            }
            // if the order does not exist throw an exception
            if (Orderexist == false)
            {
                throw new ExceptionOrderNotExist();
            }
            if (!ValidCustomer) //if customer is not valid
            {
                throw new ExceptionCustomerNotExist();
            }
            if (!ValidProduct)
            {
                throw new ExceptionProductNotExist();
            }
        }
        #endregion


        #region Delete
        // method to Delete a order from the list

        public void Delete(Order tmp)
        {
            //try
            //{
            bool Orderexist = false;
            //go thru list to find orders whose id matches the id of order parameter
            //delete that order from the list
            //use List method Remove
            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].OrderNumber == tmp.OrderNumber)
                {
                    Orderexist = true;
                    _orders.Remove(_orders[i]);
                    break;
                }

            }
            if (Orderexist == false)
            {
                throw new ExceptionOrderNotExist();
            }
        }

    }
    #endregion
}

