using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    //after new push 
    public class ProductBL
    {
        ProductDAL pd1 = new ProductDAL();  //instance variable of type productDAL

        public ProductBL()   //ctor 
        {
            pd1 = new ProductDAL();
        }

        public void CreateProduct(Product temp) //create product
        {
            try
            {
                pd1.Create(temp);
            }
            catch
            {
                throw;
            }
        }
        public List<Product> Read() //read all products
        {
            try
            {
                return pd1.Read();
            }
            catch
            {
                throw;
            }
        }
        public Product Read(int id) //read one product
        {
            try
            {
                return pd1.Read(id);
            }
            catch
            {
                throw;
            }
        }
        public void UpdateProduct(Product temp)  //update product
        {
            try
            {
                pd1.Update(temp);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProduct(Product temp)    //delete product
        {
            try
            {
                pd1.Delete(temp);
            }
            catch
            {
                throw;
            }
        }


    }
}
