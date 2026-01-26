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
            Product pr1 = new Product(450, "Gummy Bears", 2);
            Console.WriteLine(pr1);

            Person[] persons = new Person[6];

            ///using the streamreader 
            StreamReader reader = new StreamReader(@"..\..\TextFile1.txt");

            ///read from text file
            using (reader)
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    string name = reader.ReadLine();

                    string id = reader.ReadLine();

                    persons[i] = new Person(name, id);
                }

            }

            ///print array 
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }

            CreditCard cr1 = new CreditCard("Rachel Cohen", "456789994546", "7-31", "342");
            Customer c1 = new Customer("Rachel", "678", cr1);
            Console.WriteLine(c1);
            
        }
    }
}
