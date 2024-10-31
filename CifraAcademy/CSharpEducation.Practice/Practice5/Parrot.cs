using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
  internal class Parrot : Animal
  {
    internal string Color {  get; set; }

    internal new void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }
    internal void MakeSound(string word)
    {
      Console.WriteLine(word);
    }
    internal Parrot(string name, int age, string color) : base(name, age)
    {
      Console.WriteLine($"Cat born!");
      this.Color = color;
    }
  }
}
