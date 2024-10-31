using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Contractor : Employee
    {

        public int HourlyRate { get; set; }

        public Contractor(string name, decimal salary, int hourlyRate) : base(name, salary)
        {
            this.HourlyRate = hourlyRate;
            
        }
       
        internal  decimal CalculateBonus(int hourlyRate)
        {
                       
            return hourlyRate * 0.01m * Salary;
        }
    }
}
