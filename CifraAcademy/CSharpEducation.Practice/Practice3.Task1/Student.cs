using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice3.Task1
{
    internal class Student
    {
        private string name = "Vasay";
        private int age = 35;
        private double averageScore;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }
        public int Age { get { return age; } set { age = value; } }
        public double AverageScore
        {
            get
            {
                return averageScore;
            }
            set 
            {
                if ((value < 0) || (value > 5))
                    Console.WriteLine("Средний балл не может быть не меньше 0 и не больше 5");
                else averageScore = value;
            }
        }

        public void InfoStudent() 
        {
            Console.WriteLine($" Name: {name}   Age: {age}");
        }

    }
}
