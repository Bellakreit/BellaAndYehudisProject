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
        public ProductDAL pd1;  //instance variable of type productDAL

        public ProductBL(ProductDAL product)   //ctor 
        {
            this.pd1 = product;
        }

        public void CreateProduct(Product temp) //create product
        {
            try
            {
                pd1.Create(temp);
            }
            catch(ExceptionProductExists ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public List<Product> Read() //read all products
        {
                return pd1.Read();
        }
        public Product Read(int id) //read one product
        {
            try
            {
                return pd1.Read(id);
            }
            catch(ExceptionProductNotExist ex)
            {
                Console.WriteLine(ex.Message);
                throw;
                
            }
            return null;
        }
        public void UpdateProduct(Product temp)  //update product
        {
            try
            {
                pd1.Update(temp);
            }
            catch(ExceptionProductNotExist ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void DeleteProduct(Product temp)    //delete product
        {
            try
            {
                pd1.Delete(temp);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


    }
}
