using System;
using System.Collections.Generic;
using System.Linq;


namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //   int qtyFood = int.Parse(Console.ReadLine());
            //  Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            //  int biggestOrder = orders.Max();
            //  int count = orders.Count;
            //  for (int i = 0; i < count; i++)
            //  {
               // if (qtyFood >= orders.Peek())
              //  {
              //   qtyFood -= orders.Dequeue();
              //   continue;
             //   }

                //break;
            //  }
            //  Console.WriteLine(biggestOrder);

           //   Console.WriteLine(orders.Count <= 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");


            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queueOfOrders = new Queue<int>();

            foreach (var order in orders)
            {
                queueOfOrders.Enqueue(order);
            }

            int maxOrder = int.MinValue;

            while (quantity > 0 && queueOfOrders.Count > 0)
            {
                int currentOrder = queueOfOrders.Peek();

                if (currentOrder > maxOrder)
                {
                    maxOrder = currentOrder;
                }

                if (quantity - currentOrder >= 0)
                {
                    quantity -= currentOrder;
                    queueOfOrders.Dequeue();
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(maxOrder);
            if (queueOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" " , queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
