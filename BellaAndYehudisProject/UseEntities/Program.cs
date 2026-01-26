using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

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

            CreditCard creditcard1 = new CreditCard("Rachel Cohen", "123456788", "7-23", "567");
            Customer c1 = new Customer("Rachel", "234", creditcard1);
            Console.WriteLine(c1);

            Employee emp = new Employee("Joe Mo", "123", 45000);
            Console.WriteLine(emp);

            Manager m1 = new Manager("123", "Zelli Roth", 100000, 25);
            Console.WriteLine(m1);

            SalesRep sr1 = new SalesRep("324", "Sara Klein", 32000, .12);
            Console.WriteLine(sr1);
        }
    }
}
