using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice3.Task1.Сalculator;

namespace Practice3.Task1
{
    public class Structs
    {
        public struct PointXY
        {
            public int x;
            public int y;

            public int X { get { return x; }  set { x = value; } }
            public int Y { get { return y; } set { y = value; } }

            public void PrintXY()
            {
                Console.WriteLine($"Координата х: {X}, у : {Y}");
            }
        }


        public double Distance(PointXY a, PointXY b)
        {
            double deltaX = Сalculator.Diff(a.x, b.x);
            double deltaY = Сalculator.Diff(a.y, b.y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        }

        
    }
}
