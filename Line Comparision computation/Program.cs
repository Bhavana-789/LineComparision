using System;

namespace Line_Comparision_computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation");

            Console.WriteLine("Please enter x1 and y1 coordinates");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter x2 and y2 coordinates");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());
            length.UC1(x1,y1,x2,y2);

            Console.WriteLine("Welcome to Line Equality program");

            Console.WriteLine("Please enter l1 and m1 coordinates");
            int l1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter l2 and m2 coordinates");
            int l2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            length.UC2(x1, y1, x2, y2);

            Console.WriteLine("To Compare Both Line by CompareTo method");
            Console.WriteLine("Please Enter a1 and b1 coordinates");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a2 and b2 coordinates");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            length.UC3(l1, m1, l2, m2);




        }
    }
}
