namespace MathHelper
{
    public class MathHelper
    {
        /// <summary>
        /// Выполняет a + b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public static int Summ(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public static double Summ(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a - b</returns>
        public int Diff(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a - b</returns>
        public double Diff(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a * b</returns>
        public double Multiplication(double a, double b)
        { 
            return a * b; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a * b</returns>
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a / b</returns>
        public double Division(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a / b</returns>
        public double Division(int a, int b)
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b);
        }
    }
}
