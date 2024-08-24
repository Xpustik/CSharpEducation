using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Manager : Employee
    {
        
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, int teamSize) : base( name, salary) 
        {
            this.TeamSize = teamSize;
            count++;
        }
        ~Manager() 
        {
            count--;
        }
        internal override decimal CalculateBonus()
        {
            decimal bonus = 0.2m;
            if (count > 5)  bonus = 0.25m;
            return this.Salary * bonus;
        }
    }
}
