using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 123;
            string userId = "BPaetow";

            Console.WriteLine("Please enter your user Id:");
            string userIdInput = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            int passwordInput = int.Parse(Console.ReadLine());

            if (userIdInput == userId && passwordInput == password)
            {
                Console.WriteLine("Logging in...") ;
            }
            else
            {
                Console.WriteLine("incorrect ID or Pin!");
            }
        }
    }
}
