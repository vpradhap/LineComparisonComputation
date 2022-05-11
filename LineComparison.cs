using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    public class LineComparison
    {
        double line1,line2;
        public void LineLength()
        {
            // x,y Coordinates User Input for Line1 & Line2 
            Console.WriteLine("\nEnter x,y Coordinates for a Line1");
            Console.Write("x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter x,y Coordinates for a Line2");
            Console.Write("x3=");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3=");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x4=");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4=");
            int y4 = Convert.ToInt32(Console.ReadLine());
            
            //Displaying End Pionts for Line & Line2
            Console.WriteLine("\nLine1\tFirst Point ({0},{1}) \tSecond Point ({2},{3})", x1,y1,x2,y2);
            Console.WriteLine("Line2\tFirst Point ({0},{1}) \tSecond Point ({2},{3})", x3, y3, x4, y4);
            
            //Calculation to find Length of Two Lines
            line1 = Math.Sqrt( Math.Pow((x2 - x1) , 2) +  Math.Pow((y2 - y1) , 2) );
            Console.WriteLine("\nLength of the Line1 = " +line1);
            line2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of the Line2 = " +line2);
        }
        public void Equality()
        {
            //Equality of Two Lines
            Console.Write("\n\tLine1 is Equal to Line2 : ");
            Console.WriteLine(line1.Equals(line2));
        }
        public void Comparison()
        {
            //Comparison of Two Lines
            Console.WriteLine("\n\t\t<<<<<<<<<<  "+line1.CompareTo(line2)+"  >>>>>>>>>>");
            Console.WriteLine("\nIf  ( 0 )  Line1 is Equal to Line2");
            Console.WriteLine("\nIf  ( 1 )  Line1 is Greater Than Line2");
            Console.WriteLine("\nIf  ( -1 )  Line1 is Lesser Than Line2");
        }
    }
}
