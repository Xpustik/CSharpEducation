using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Manager : Employee
    {
        
        public static int TeamSize { get; set; }

        public Manager(string name, decimal salary) : base( name, salary) 
        {
            //count++;
            TeamSize = count;
        }
        ~Manager() 
        {
           // count--;
            TeamSize = count;
        }
        internal override decimal CalculateBonus()
        {
            decimal bonus = 0.2m;
            if (count > 5)  bonus = 0.25m;
            return this.Salary * bonus;
        }
    }
}
