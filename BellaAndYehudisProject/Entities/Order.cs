using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int ProductNumber { get; set; }
        public string CustomerID { get; set; }
        public int OrderQuantity { get; set; }
        
        private static int ordernumber = 1;

        public int OrderNumber { get; private set; }

        /// <summary>
        /// ctor which autoincriments the order number
        /// </summary>
        /// <param name="productnumber"></param>
        /// <param name="customerid"></param>
        /// <param name="orderquantity"></param>
        public Order(int productnumber, string customerid, int orderquantity)
        {
            ProductNumber = productnumber;
            CustomerID = customerid;
            OrderQuantity = orderquantity;
            OrderNumber = ordernumber;
            //DateTime TimeOfOrder = DateTime.Now;
            ordernumber++;

        }

        public override string ToString()  //tostring for printing
        {
            return $"Order #: {OrderNumber}, Product #: {ProductNumber}, Customer ID: {CustomerID}, Quantity: {OrderQuantity}";
        }

    }
}
