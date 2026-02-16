//Creating DAL class for products
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
    public  class ProductDAL
    {
        static List<Product> list = new List<Product>();   //this will be list to save the Product objects
                                                           //needs to be static so only one copy is made
        #region ctor
        /// <summary>
        /// ctor to initilize ProductDAL with list from text file
        /// </summary>
        public ProductDAL()
        {
            InitalizeList();
        }
        //ctor goes here
        //ctor should call method initialize list to fill list with beginning values
        //beginning values are found in a text file
        #endregion

        #region InitalizeList
        //InitializeList() goes here
        //method reads in values for Product objects from text files
        //creates the objects and add to the list of Product
        public void InitalizeList()
        {
            StreamReader reader = new StreamReader(@"..\..\..\DAL\ProductsFile.txt"); //reading values from text file
            ///read from text file
            ///take text file info and make into new products
            using (reader)
            {
                while (true)
                {
                    string numberline = reader.ReadLine();
                    if (numberline == null)
                        break;
                    int productnumber = int.Parse(numberline);
                    string productname = reader.ReadLine();
                    double costperunit = double.Parse(reader.ReadLine());
                    int amountinstock = int.Parse(reader.ReadLine());
                    list.Add(new Product(productnumber, productname, costperunit, amountinstock));
                }

            }


        }

        #endregion

        #region Create
        //method to insert a new Product

        public void Create(Product tmp)
        {
            //always make a copy of the object received as a parameter
            //check to see if that id already exists in the list
            //add new Person to list.
            //use List method .Add( ) 
            foreach (Product products in list) //loop through products to see if the ID already exists
            {
                if (tmp.ProductNumber == products.ProductNumber)  // if product already exists throw exception
                {
                    throw 
                        new ExceptionProductExists();
                }
            }
            Product addition = new Product(tmp.ProductNumber, tmp.ProductName, tmp.CostPerUnit, tmp.AmountInStock);
            list.Add(addition);
        }
        #endregion

        #region Read one Product
        //method to return one Product according to ID

        public Product Read(int id)
        {
            //loop thru list checking to see if current Product ojbect's id matches
            // id of parameter
            //when matching id is found, MAKE A COPY OF THE PRODUCT, and return the Product copy

            foreach (Product products in list) //loop through products to see if the ID already exists
            {
                if (id == products.ProductNumber)
                {
                   return new Product(products.ProductNumber, products.ProductName, products.CostPerUnit, products.AmountInStock);
                }
            }
            // if you reach this - the product does not exist - throw exception
                throw
                    new ExceptionPrdocutNotExist();
        }
        #endregion

        #region Read all the list
        //method to return the entire list

        public List<Product> Read()
        {
            //make a copy of the list and return the list copy
            //there are 2 ways to do this.
            //Option one: go thru the original list, and for each Product, make a copy of the object,
            //            and add the copy to a new list that you have initialized.
            //             return the new list
            List<Product> newProductList = list.Select(product => new Product(product.ProductNumber,
            product.ProductName, product.CostPerUnit, product.AmountInStock)).ToList();

            return newProductList;

        }
        #endregion


        #region Update
        //method Update to change some values of a Product

        public void Update(Product tmp)
        {
            bool productexist = false; // is there such a product?
            //go thru list to find Product whose id matches the id of Product parameter
            foreach (Product products in list) //loop through products to see if the ID already exists
            {
                if (tmp.ProductNumber == products.ProductNumber)
                {
                    productexist = true;
                    //change the values of Product object in list to match the values of Product parameter
                    products.ProductNumber = tmp.ProductNumber;
                    products.ProductName = tmp.ProductName;
                    products.CostPerUnit = tmp.CostPerUnit;
                }
            } 
            // if the product does not exist throw an exception
            if (productexist == false)
            {
                throw new ExceptionPrdocutNotExist();
            }
       }
        #endregion

        #region Delete
        // method to Delete a product from the list

        public void Delete(Product tmp)
        {
            bool productexist = false;
            //go thru list to find Product whose id matches the id of Product parameter
            //delete that product from the list
            //use List method Remove
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i].ProductNumber == tmp.ProductNumber)
                {
                    productexist = true;                    
                    list.Remove(list[i]);
                    break;
                }
            }
            // if the product does not exist throw an exception
            if (productexist == false)
            {
                throw new ExceptionPrdocutNotExist();
            }



        }
        #endregion
    }
}
