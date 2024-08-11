namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[,] GetArray(int a)
        {
            if (a > 0)
            {
                int[,] value = new int[a, a];
                return value;
            }
            else 
            {
                Console.WriteLine("Некоректный размер массива");
                ArgumentException.Equals(a,a);
               
            }
        }
    }
}
