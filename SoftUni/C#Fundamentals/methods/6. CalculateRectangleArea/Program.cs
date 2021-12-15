using System;

namespace _6._CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine(Area(width, hight));

        }
        public static int Area(int width, int hight)
        {
            return width * hight;
        }
    }
}
