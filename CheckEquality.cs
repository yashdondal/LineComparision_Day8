using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparsion_DAY8
{
    
        public class CheckEquality
        {
            public void CalculateLengthofLine()
            {
                int x1 = 12, x2 = 3, y1 = 5, y2 = 9;
                int x3 = 10, x4 = 18, y3 = 11, y4 = 7;


                double LengOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double LengOfLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));


                Console.WriteLine("\n Length of Line is : {0}", LengOfLine1);
                Console.WriteLine(" Length of Line is : {0}\n", LengOfLine2);

                //Checking EQuality of Line
                bool status = LengOfLine1.Equals(LengOfLine2);
                Console.WriteLine(status);

                if (status)
                {
                    Console.WriteLine("Line1 is Equal to Line2");
                }
                else
                {
                    Console.WriteLine("Line1 is Not Equal to Line2");
                }

            }
        }
   }

