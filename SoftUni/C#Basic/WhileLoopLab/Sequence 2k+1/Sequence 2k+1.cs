using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while (count <= n)
            {
                Console.WriteLine(count);
                count = (count * 2) + 1;
                
            }
        }
    }
}
