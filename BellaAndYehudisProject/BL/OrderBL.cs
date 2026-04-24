using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    internal class OrderBL
    {
        public OrderDAL od1;  //instance variable of type OrderDal

        public OrderBL(OrderDAL order)   //ctor 
        {
            this.od1 = order;
        }

        #region Create
        public void CreateOrder(Order temp) //create order
        {
            try
            {
                od1.Create(temp);
            }
            catch (ExceptionCustomerNotExist)
            {
                throw;
            }
            catch (ExceptionProductNotExist)
            {
                throw;
            }
}
        #endregion

        #region ReadALL
        public List<Order> Read() //read all orders
        {
            return od1.Read();
        }
        #endregion

        #region read by order id
        public Order Read(int id) //read one order
        {
            try
            {
                return od1.Read(id);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;

            }
        }
        #endregion

        #region read by product
        public Order ReadbyProduc(int productID) //read one order
        { 
            try
            {
                return od1.ReadbyProduct(productID);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;

            }
        }
        #endregion

        #region read by customer
        public Order ReadbyCustomer(string custID) //read one order
        {
            try
            {
                return od1.ReadbyCustomer(custID);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;

            }
        }
        #endregion

        #region Update

        public void Update(Order temp)  //update order
        {
            try
            {
                od1.Update(temp);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;

            }
        }
        #endregion

        public void Delete(Order temp)    //delete order
        {
            try
            {
                od1.Delete(temp);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;

            }
        }

    }
}
