using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
  internal class Cat : Animal 
  {
    internal override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
    internal Cat(string name,int age) : base(name, age) 
    {
      Console.WriteLine($"Cat born!");
    }
  }
}
