using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductNumber { get; set; } //the number of the product
        public string ProductName { get; set; } //product name
        public double CostPerUnit { get; set; } //the cost per unit
        public int AmountInStock { get; set; } //#how much is in stock?
        /// <summary>
        /// Product now needds a number, name and CostperUnit
        /// </summary>
        /// <param name="productNumber"></param>
        /// <param name="productName"></param>
        /// <param name="costPerUnit"></param>
        public Product(int productNumber, string productName, double costPerUnit)
        {
            ProductNumber = productNumber;
            ProductName = productName;
            CostPerUnit = costPerUnit;
        }
        public override string ToString()
        {
            return $"Product Name = {ProductName}, Product Number = {ProductNumber}, Cost Per Unit = ${CostPerUnit}";
        }
    }
}
