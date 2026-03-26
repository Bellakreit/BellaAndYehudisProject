using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //creates class "Person"
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        /// <summary>
        /// ctor returns name and ID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public Person(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public override string ToString() { return $"Name: {Name}\nID: {ID}"; }
    }
}
