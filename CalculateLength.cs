using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsion_DAY8
{
    public class CalculateLength
    {
        public void CalculateLengthofLine()
        {
            int x1 = 12;
            int x2 = 3;
            int y1 = 5;
            int y2 = 9;


            double LengOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("\n Length of Line is : {0}", LengOfLine);

        }
    }
}

 