using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
  internal class Animal
  {
    internal string Name { get; set; }
    internal int Age { get; set; }

    internal void Eat()
    {
      Console.WriteLine("Animal is eating");
    }
    internal void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }
    internal virtual void MakeSound()
    {
      Console.WriteLine("Some generic animal sound");
    }

    internal Animal(string name, int age) 
      {
      this.Name = name;
      this.Age = age;
      }
  }
}
