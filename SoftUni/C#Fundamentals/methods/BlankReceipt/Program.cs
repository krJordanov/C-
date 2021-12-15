using System;

namespace BlankReceipt
{
    class Program
    {
        static void Main()
        {
            PrintReceipt();
        }

        public static void BlankReceiptHeader() 
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void BlankReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void BlankReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("(c) SoftUni");
        }
        public static void PrintReceipt()
        {
            BlankReceiptHeader();
            BlankReceiptBody();
            BlankReceiptFooter();
        }
    }
}
