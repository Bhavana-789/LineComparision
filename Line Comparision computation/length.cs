using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_computation
{
    internal class length
    {
        public static void UC1(int x1, int x2, int y1, int y2)
        {
            double temp1, temp2, result;
            temp1 = Math.Pow((x2 - x1), 2);
            temp2 = Math.Pow((y2 - y1), 2);
            result = Math.Sqrt(temp1 + temp2);

            Console.WriteLine("Length between Coordinates is" + result);

        }
        public static void UC2(int l1, int m1, int l2, int m2)
        {
            int len1, len2;
            if (l1 == l2)
            {
                Console.WriteLine(m1.Equals(m2));
            }
            else
            {
                len1 = m1 - l1;
                len2 = m2 - l2;
                Console.WriteLine(len1.Equals(len2));
            }
        }
        public static void UC3(int a1, int b1, int a2, int b2)
        {
            int le1, le2;
            if (a1 == a2)
            {
                int temp = b1.CompareTo(b2);
                if (temp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (temp >= 0)
                {
                    Console.WriteLine("Second line is less than first line");
                }
                else
                {
                    Console.WriteLine("Second line is greater than First line");
                }
            }
            else
            {
                le1 = b1 - a1;
                le2 = b2 - a2;
                int temp = le1.CompareTo(le2);
                if (temp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (temp >= 0)
                {
                    Console.WriteLine("Second line is less than first line");
                }
                else
                {
                    Console.WriteLine("Second line is greater than First line");
                }
            }
        }
    }
}