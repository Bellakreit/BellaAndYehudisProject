using System;
using System.Collections.Generic;
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
            Product[] p1 = new Product[4];
            StreamReader reader = new StreamReader(@"..\..\..\DAL\ProductDAL.txt");
            ///read from text file
            using (reader)
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    int productnumber = int.Parse(reader.ReadLine());
                    string productname = reader.ReadLine();
                    double costperunit = double.Parse(reader.ReadLine());

                    p1[i] = new Product(productnumber, productname, costperunit);
                }

            }

        }

        #endregion

        #region Create
        //method to insert a new Person

        public void Create(Person tmp)
        {
            //always make a copy of the object received as a parameter
            //check to see if that id already exists in the list
            //add new Person to list.
            //use List method .Add( ) 
        }
        #endregion

        #region Read one Person
        //method to return one Person according to ID

        public Person Read(int id)
        {
            //loop thru list checking to see if current Person ojbect's id matches
            // id of parameter
            //when matching id is found, MAKE A COPY OF THE PERSON, and return the Person copy
        }
        #endregion

        #region Read all the list
        //method to return the entire list

        public List<Person> Read()
        {
            //make a copy of the list and return the list copy
            //there are 2 ways to do this.
            //Option one: go thru the original list, and for each Person, make a copy of the object,
            //            and add the copy to a new list that you have initialized.
            //             return the new list

        }
        #endregion


        #region Update
        //method Update to change some values of a Person

        public void Update(Person tmp)
        {
            //go thru list to find Person whose id matches the id of Person parameter
            //change the values of Person object in list to match the values of Person parameter

        }
        #endregion

        #region Delete
        // method to Delete a person from the list

        public void Delete()
        {
            //go thru list to find Person whose id matches the id of Person parameter
            //delete that person from the list
            //use List method Remove
        }
        #endregion
    }
}
