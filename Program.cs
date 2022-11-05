using System;

namespace CoverCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 21)
            {
                float cash = 0.0f;
                Console.Write("Enter cash: ");
                cash = Convert.ToSingle(Console.ReadLine());
                if (cash >= 10.0f)
                    Console.WriteLine("Welcome to the club!");
                else
                    Console.WriteLine("You do not have the cover charge. ");
            }
            else
            {
                Console.WriteLine("You are too young to enter. ");
            }
        }
    }
}