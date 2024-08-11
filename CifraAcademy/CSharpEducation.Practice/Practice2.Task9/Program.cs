using System.IO.IsolatedStorage;

namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Введи размер массива ");
           
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var number = new Program();
            var number1 = number.GetArray(n);
           
            //Program.PrintArray(number1);
                        
            number1 = Program.FillArray(number1);
            Program.PrintArray(number1);

            Console.WriteLine("Введи число ");
            
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            number1 = Program.FillArray(number1, a);
            Program.PrintArray(number1);

           // int[,] number3 = new int[a, a];
        }
        /// <summary>
        /// Создает массив типа int размерностью "n"
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Массив int[n]</returns>
        public int[] GetArray(int n)
        {
            int length = 0;
            int[] value = new int[1];
           
            length = value.Length;
            Array.Resize(ref value, n);
                       
            return value;
        }


        /// <summary>
        /// Выводит в консол массис int[] n
        /// </summary>
        /// <param name="n"></param>
        public static void PrintArray(int[] n)
        {
            
            foreach (var item in n)
            {
                Console.WriteLine(item);

               // int value = rnd.Next(0, 100);
            }
        }


        /// <summary>
        /// Заполняет массив случайными числами
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Массив "int[n]"</returns>
        public static int[] FillArray(int[] n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n.Length; i++) 
            {
                int value = rnd.Next(0,100);
                n[i] = value;
               // Console.WriteLine(value);
            }
         
            return n;
        }
        /// <summary>
        /// Заполняет массив "n[]" числами "a"
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <returns>Массив "int[n]"</returns>
        public static int[] FillArray(int[] n,int a)
        {
            Random rnd = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = a;           
            }

            return n;
        }
    }
}
