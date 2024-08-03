using Practice3.Task1;

namespace Practice3.Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PointXY point1 = new PointXY(3, 4);
            //PointXY point2 = new PointXY(6, 7);

            Practice3.Task1.Structs.PointXY point1 = new();
            point1.X = 3;
            point1.Y = 4;
            Structs.PointXY point2 = new();
            point2.X = 7;
            point2.Y = 8;

            point2.PrintXY();

            var mc = new Structs();

            Console.WriteLine(Structs.Distance(point1,point2));

         //Practice3.Task1.Сalculator.Diff(point1, point2);
         //Practice3.Task1.Structs.PointXY.


        }
    
    
    
    }
}
