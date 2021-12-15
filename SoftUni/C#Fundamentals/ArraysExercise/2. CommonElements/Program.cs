using System;
using System.Linq;

namespace _2._CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string[] result = arr2.Intersect(arr1).ToArray();   // tuk 2riq masiv "arr2" se sravnqva s pyrviq(za ednakvi elementi) "arr1"

            Console.WriteLine(string.Join(" ", result));

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    string currentElement = arr2[i];

            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (currentElement == arr1[j])
            //        {
            //            Console.Write(currentElement+" ");
            //        }
            //    }
            //}
         
        }
    }
}
