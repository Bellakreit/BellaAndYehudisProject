using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    ///add inheriter sales rep to employee class
    public class SalesRep
        :Employee
    {
        public double CommissionRate { get; set; } //what is the sales reps comission rate?

        public SalesRep(string id, string name, double salary, double commisionrate)
            :base(name, id, salary)
        {
            CommissionRate = commisionrate;  
        }

        /// <summary>
        /// tostring for sales rep info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}Commission Rate: {CommissionRate}\n";
        }
    }
}
