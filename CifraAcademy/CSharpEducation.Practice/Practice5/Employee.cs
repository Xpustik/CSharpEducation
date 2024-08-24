using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Employee
    {
        internal static int count = 0;
        public string Name {  get; set; }
        public decimal Salary {  get; set; }

        public Employee(string name, decimal salary) 
        {
            this.Name = name;
            this.Salary = salary;
            count++;
        }
         ~Employee() 
        {
            count--;
        }
        internal virtual decimal CalculateBonus()
        {
            return this.Salary * 0.1m;
        }
    }
}
