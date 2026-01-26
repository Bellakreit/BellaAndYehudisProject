using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    ///add inheriter sales rep to employee class
    internal class SalesRep
        :Employee
    {
        public int CommissionRate { get; set; } //what is the sales reps comission rate?

        public SalesRep(string id, string name, double salary, int commisionrate)
            :base(name, id, salary)
        {
            CommissionRate = commisionrate;  
        }
    }
}
