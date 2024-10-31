namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var tom = new Employee("Tom", 100);
           
            var tony = new Manager("Tony", 100);
           
            var timy = new Manager("Timy", 100);
            var antony = new Manager("Antony", 100);
            var bany = new Manager("Bany", 100);
            var billy = new Contractor("Billy", 100, 5);

            var cach = tom.CalculateBonus();
            Console.WriteLine($" {tom.Name} bonus: {cach}");
           
            cach = tony.CalculateBonus();
            Console.WriteLine($" {tony.Name} bonus: {cach}");
            
            cach = timy.CalculateBonus();
            Console.WriteLine($" {timy.Name} bonus: {cach}");
            
            cach = antony.CalculateBonus();
            Console.WriteLine($" {antony.Name} bonus: {cach}");

            cach = bany.CalculateBonus();
            Console.WriteLine($" {bany.Name} bonus: {cach}");

            cach = billy.CalculateBonus(10);
            Console.WriteLine($" {billy.Name} bonus: {cach}");
            
            Console.WriteLine(Employee.count);

        }
    }
}
