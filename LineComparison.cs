using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        public void LineLength()
        {
            Console.WriteLine("Enter x,y Coordinates for a Line");
            Console.Write("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Point ({0},{1}) \nSecond Point ({2},{3})", x1,y1,x2,y2);
            double Line = Math.Sqrt( Math.Pow((x2 - x1) , 2) +  Math.Pow((y2 - y1) , 2) );
            Console.WriteLine("Length of the Line = " +Line);
        }
    }
}
