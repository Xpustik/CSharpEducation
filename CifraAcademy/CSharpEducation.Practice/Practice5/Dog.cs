using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
  internal class Dog : Animal
  {
    internal override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
    internal Dog(string name, int age) : base(name, age)
    {
      Console.WriteLine($"Dog born!");
    }
  }
}
