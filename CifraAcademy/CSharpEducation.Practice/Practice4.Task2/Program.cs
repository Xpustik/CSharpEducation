using MathHelper;
//using Person;
using static System.Console;
namespace Practice4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            
            int a = 4;
            int b = 5;
            int c = MathHelper.MathHelper.Summ(a,b);
            var math = new MathHelper.MathHelper();
            WriteLine(MathHelper.MathHelper.Summ(a, b));

            c =math.Diff(a,b);
            WriteLine($"a = {a}, b = {b}");

            WriteLine($"a - b = {math.Diff(a,b)}");
            WriteLine($"a / b = {math.Division(a,b)}");
            WriteLine($"a * b = {math.Multiplication(a,b)}");

            var person1 = new Person.Person { Name = "Vasay", Age = 36 };
            var person2 = new Person.Person { Name = "Fedor", Age = 12 };
            var person3 = new Person.Person {Name = "Polik", Age= 13 };

            Person.Person.PerInfo(person1);
            Person.Person.PerInfo(person2);
            Person.Person.PerInfo(person3);
           
        }
    }
}
