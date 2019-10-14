using System;

namespace Open_Lab_02._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsDivisible(number));
        }
        private static bool IsDivisible(int number)
        {
            bool boolean = number % 100 == 0;
            return !boolean;

        }
    }
}