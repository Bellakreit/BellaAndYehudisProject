using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using BL;
using System.Diagnostics.Eventing.Reader;

namespace UseEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   
            //Product pr1 = new Product(450, "Gummy Bears", 2);
            //Console.WriteLine(pr1);

            //Person[] persons = new Person[6];

            /////using the streamreader 
            //StreamReader reader = new StreamReader(@"..\..\TextFile1.txt");

            /////read from text file
            //using (reader)
            //{
            //    for (int i = 0; i < persons.Length; i++)
            //    {
            //        string name = reader.ReadLine();

            //        string id = reader.ReadLine();

            //        persons[i] = new Person(name, id);
            //    }

            //}

            /////print array 
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            //CreditCard creditcard1 = new CreditCard("Rachel Cohen", "123456788", "7-23", "567");
            //Customer c1 = new Customer("Rachel", "234", creditcard1);
            //Console.WriteLine(c1);

            //Employee emp = new Employee("Joe Mo", "123", 45000);
            //Console.WriteLine(emp);

            //Manager m1 = new Manager("123", "Zelli Roth", 100000, 25);
            //Console.WriteLine(m1);

            //SalesRep sr1 = new SalesRep("324", "Sara Klein", 32000, .12);
            //Console.WriteLine(sr1);

            //Product lego = new Product(5, "Lego", 32.89, 50);
                //ProductDAL product = new ProductDAL(); ///create a product dal
                //product.Create(lego); //add lego
                //Console.WriteLine(string.Join("\n", product.Read())); ///print the products list
                //Console.WriteLine();
                //Console.WriteLine("Reading product 2:");
                //Console.WriteLine(string.Join("\n", product.Read(2))); //read product #2
                //Console.WriteLine();
                //Console.WriteLine("Update product 3 to magnet tiles:");
                //Product newproduct = new Product(3, "magnet tiles", 100.45, 450);
                ////product.Update(newproduct);
                ////Console.WriteLine(string.Join("\n", product.Read(3)));
                //////delete product number 11
                ////Console.WriteLine("\nDelete product 11:");
                ////product.Delete(new Product(11, "magnet tiles", 100.45, 450));
                ////Console.WriteLine(string.Join("\n", product.Read()));

                ////using BL layer
                ////create a productDAL
                //ProductDAL pdal = new ProductDAL();
                ////create a productBL from the productDAL
                //ProductBL pbl = new ProductBL(pdal);


                ////CRUD methods for BL
                //////create 
                //pbl.CreateProduct(lego);
                ////read list
                //Console.WriteLine(string.Join("\n", pbl.Read()));
                ////read one product
                //Console.WriteLine("Reading product 2");
                //Console.WriteLine(string.Join("\n", pbl.Read(2)));
                ////update list
                //Console.WriteLine();
                //Console.WriteLine("Product 3");
                //Console.WriteLine(string.Join("\n", pbl.Read(3)));
                //pbl.UpdateProduct(newproduct);
                //Console.WriteLine("updated product 3:");
                //Console.WriteLine(string.Join("\n", pbl.Read(3)));
                ////delete
                //Console.WriteLine();
                //Console.WriteLine("deleting product lego");
                //pbl.DeleteProduct(lego);
                //Console.WriteLine(string.Join("\n", pbl.Read()));


                /////exceptions start here:
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine("Test exceptions");

                ////create product number twice
                //Console.WriteLine("create product superpower");
                //Product superpower = new Product(3, "super power", 6.7, 0);
                //pbl.CreateProduct(superpower);

            //read wrong product
            //Console.WriteLine("reading product 90:");
            //Console.WriteLine(string.Join("\n", pbl.Read(90)));

            //update non- product
            //Console.WriteLine("updated product 78:");
            //pbl.Read(78);

            //delete non-product
            //Console.WriteLine("deleting product 35");
            //Product horsy = new Product(35, "horsy", 8.90, 0);
            //pbl.DeleteProduct(horsy);

            //CustomerDAL cust = CustomerDAL.Instance;
            //Customer c1 = new Customer("Rachel", "234", new CreditCard("Rachel Cohen", "123456788", "7-23", "567"));
            //cust.Create(c1);
            //Console.WriteLine(string.Join("\n", cust.Read()));
            //Console.WriteLine("read one customer");
            //Console.WriteLine(string.Join("\n", cust.Read("123")));
            //Console.WriteLine("update bella to bella sara");
            //Customer cUpdate = new Customer("Bella sara", "123", new CreditCard("Bella Kreit", "12345678901234567", "12/28", "124"));
            //cust.Update(cUpdate);
            //Console.WriteLine(string.Join("\n", cust.Read("123")));
            //Console.WriteLine("delete bella sara ");
            //cust.Delete(cUpdate);
            //Console.WriteLine(string.Join("\n", cust.Read()));

            ////CRUD for customers using BL layer
            ////create a customerBL from the customerDAL
            //Console.WriteLine("BL layer!");
            //CustomerBL cbl = new CustomerBL(cust);
            //Customer cust2 = new Customer("Sara", "342", new CreditCard("Sara Klein", "12345678901234567", "12/28", "124"));
            //cbl.CreateCustomer(cust2);
            ////read list
            //Console.WriteLine(string.Join("\n", cbl.Read()));
            ////read one customer
            //Console.WriteLine("reading customer 342:");
            //Console.WriteLine(string.Join("\n", cbl.Read("342")));
            ////update list
            //Console.WriteLine("update customer 342 to Raiza Esther");
            //Customer custupdate = new Customer("Raiza Esther", "342", new CreditCard("Raiza Esther", "12345678901234567", "12/28", "124"));
            //cbl.UpdateCustomer(custupdate);
            //Console.WriteLine(string.Join("\n", cbl.Read("342")));
            ////delete
            //Console.WriteLine("delete customer 234");
            //cbl.DeleteCustomer(c1);
            //Console.WriteLine(string.Join("\n", cbl.Read()));

            ////exceptions for customers
            //Console.WriteLine("Test exceptions for customers");
            ////read wrong customer
            //Console.WriteLine("reading customer 90:");
            //Console.WriteLine(string.Join("\n", cbl.Read("90")));
            ////test delete
            //Console.WriteLine("deleteing customer that doesnt exist");
            //Customer cust3 = new Customer("goiop", "690", new CreditCard("goop", "12345678901234567", "12/30", "234"));
            //cbl.DeleteCustomer(cust3);
            //Console.WriteLine();
            ////test create already made
            //Console.WriteLine("creating a customer that already exist");
            //cbl.CreateCustomer(cust2);
            //Console.WriteLine();
            ////test update
            //Console.WriteLine("updating a non existent customer");
            //cbl.UpdateCustomer(cust3);
            //Console.WriteLine();

            //testing orders
            //creating a customer
            CustomerDAL cust = CustomerDAL.Instance;
            CustomerBL cbl = new CustomerBL(cust);
            Customer cust1 = new Customer("Sara", "555", new CreditCard("Sara Klein", "12345678901234567", "12/28", "124"));
            cbl.CreateCustomer(cust1);

            //creating a product
            ProductDAL pdal = ProductDAL.Instance;
            ProductBL pbl = new ProductBL(pdal);
            Product lego = new Product(5, "Lego", 32.89, 50);
            pbl.CreateProduct(lego); //add lego

            //create an order
            OrderDAL order = OrderDAL.Instance;
            OrderBL orderBL = new OrderBL(order);
            Order order1 = new Order(5, "555", 1);
            //orderBL.CreateOrder(order1);

            //read all orders
            Console.WriteLine("reading all orders which is one order right now");
            Console.WriteLine(string.Join("\n", orderBL.Read()));
            Console.WriteLine();

            //read it by order number
            Console.WriteLine("reading by order number");
            Console.WriteLine(string.Join("\n", orderBL.Read(1)));
            Console.WriteLine();

            //read by product number
            Console.WriteLine("reading by product number");
            Console.WriteLine(string.Join("\n", orderBL.ReadbyProduct(5)));
            Console.WriteLine();

            //read by customer number
            Console.WriteLine("reading by customer number");
            Console.WriteLine(string.Join("\n", orderBL.ReadbyCustomer("555")));
            Console.WriteLine();

            //update normal without exceptions
            Order order1update = new Order(1, "555", 1, 3);
            orderBL.Update(order1update);
            Console.WriteLine("printing updated order to have product 1");
            //read all orders
            Console.WriteLine("reading all orders to see update");
            Console.WriteLine(string.Join("\n", orderBL.Read()));
            Console.WriteLine();


            //delete order
            orderBL.Delete(order1update);
            Console.WriteLine("deleted order with order number 3");
            //read all orders
            Console.WriteLine("reading all orders to see after delete");
            Console.WriteLine(string.Join("\n", orderBL.Read()));
            Console.WriteLine();

            //testing exceptions 
            Console.WriteLine();
            Console.WriteLine("testing create");
            //testing create
            Console.WriteLine("testing wrong product #");
            Order order3 = new Order(65, "555", 1);
            //orderBL.CreateOrder(order3);

            Console.WriteLine("testing wrong customer #");
            Order order4 = new Order(1, "64645", 3);
            //orderBL.CreateOrder(order4);
            Console.WriteLine();
            Console.WriteLine("testing Read");
            Console.WriteLine("testing order, product, and customer doesnt exist:");

            orderBL.Read(23);
            orderBL.ReadbyProduct(65);
            orderBL.ReadbyCustomer("42342");
            Console.WriteLine();
            Console.WriteLine("testing update");

            Console.WriteLine("cannot update to this product:");
            Order order8 = new Order(18913, "123", 1, 1);
            orderBL.Update(order8);
            Console.WriteLine("no such order to update:");
            Order order9 = new Order(1, "123", 1, 90);
            orderBL.Update(order9);
            Order Order6 = new Order(1, "123", 4, 1);
            Console.WriteLine("not enough in stock:");
            orderBL.Update(Order6);
            Console.WriteLine("cannot update to this customer:");
            Order order7 = new Order(1, "54673", 1, 1);
            orderBL.Update(order7);
            Console.WriteLine();
            Console.WriteLine("testing delete");
            orderBL.Delete(order9);
            

        }
    }
}
