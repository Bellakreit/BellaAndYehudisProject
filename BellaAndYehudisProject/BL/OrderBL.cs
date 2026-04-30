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
    public class OrderBL
    {
        private readonly OrderDAL od1;  //instance variable of type OrderDal

        private readonly ProductDAL pd1; // this is to update the amount in stock
        public OrderBL(OrderDAL order)   //ctor 
        {
            this.od1 = order;
            this.pd1 = ProductDAL.Instance;
        }

        #region Create
        public void CreateOrder(Order temp) //create order
        {
            try
            {
                
                //Product p = pd1.Read(temp.ProductNumber);
                //if (p.AmountInStock < temp.OrderQuantity)  //checks if we can create the order
                //    throw new Exception("Not enough in stock.");
                //p.AmountInStock -= temp.OrderQuantity; //takes this away from amnt in stock
                //pd1.Update(p);

                od1.Create(temp);
            }
            catch (ExceptionCustomerNotExist)
            {
                throw;
                //Console.WriteLine("this customer does not exist");
            }
            catch (ExceptionProductNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch (ExceptionNotEnoughStock)
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
                //Console.WriteLine(ex.Message);
                //return null;
            }
        }
        #endregion

        #region read by product
        public Order ReadbyProduct(int productID) //read one order
        { 
            try
            {
                return od1.ReadbyProduct(productID);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
                //return null;
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
                //Console.WriteLine(ex.Message);
                //return null;
            }
        }
        #endregion

        #region Update

        public void Update(Order temp)  //update order
        {
            try
            {
                Order oldo = od1.Read(temp.OrderNumber); // this is the old order
                Product oldp = pd1.Read(oldo.ProductNumber); // this is the old product
                Product newp = pd1.Read(temp.ProductNumber); //this is the new product
                if (newp.AmountInStock < temp.OrderQuantity) //check if we have enough of the new
                    throw new ExceptionNotEnoughStock();
                oldp.AmountInStock += oldo.OrderQuantity; //take away the old quantity
                newp.AmountInStock -= temp.OrderQuantity; //add the new amnt
                pd1.Update(newp);
                pd1.Update(oldp);
                od1.Update(temp);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch (ExceptionProductNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch (ExceptionCustomerNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch(ExceptionNotEnoughStock)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Delete
        public void Delete(Order temp)    //delete order
        {
            try
            {
                Product p = pd1.Read(temp.ProductNumber);
                p.AmountInStock += temp.OrderQuantity;
                pd1.Update(p);
                od1.Delete(temp);
            }
            catch (ExceptionOrderNotExist)
            {
                throw;
                //Console.WriteLine(ex.Message);
            }
            catch (ExceptionProductNotExist) { throw; }
        }
        #endregion

    }
}
