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
        private ProductDAL _productDAL = ProductDAL._instance;
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
            
            Order order = new Order(tmp.ProductNumber, tmp.CustomerID, tmp.OrderQuantity);
           _orders.Add(order);
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

        }
        #region Update
        //method Update to change some values of a order

        public void Update(Order tmp)
        {
            bool Orderexist = false; // is there such an order?
            //go thru list to find order whose id matches the id of order parameter
            foreach (Order order in _orders) //loop through orders to see if the ID already exists
            {
                if (tmp.OrderNumber == order.OrderNumber)
                {
                    Orderexist = true;
                    //change the values of order object in list to match the values of order parameter
                    order.ProductNumber = tmp.ProductNumber;
                    order.CustomerID = tmp.CustomerID;
                    order.OrderQuantity = tmp.OrderQuantity;
                }
            }
            // if the order does not exist throw an exception
            if (Orderexist == false)
            {
                throw new ExceptionOrderNotExist();
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

