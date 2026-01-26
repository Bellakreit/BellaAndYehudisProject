using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //adds class Manager under the employee class
    public class Manager
        :Employee
    {
        public int Vetek { get; set; }  // i think how many years worked??? unsure 
        /// <summary>
        /// takes objects for manager and assigns them in a ctor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="vetek"></param>
        public Manager(string id, string name, double salary, int vetek)
            :base(name, id, salary)
        {
            Vetek = vetek;
        }
        /// <summary>
        /// tostring to print out manager details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}Vetek: {Vetek}\n";
        }
    }
}
