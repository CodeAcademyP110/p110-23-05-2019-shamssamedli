using System;
using System.Collections.Generic;

namespace BankTask_23._05._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Queue = new List<string>();


            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Please,enter number one to add new user!");
                var answer = Convert.ToInt16(Console.ReadLine());
                if (answer == 1 && Queue.Count < 5)
                {
                    Console.WriteLine("Enter:");
                    var number = Console.ReadLine();
                    Queue.Add(number);
                    Console.WriteLine("New user added");
                }

            }

            Console.WriteLine("The Queue is full!");

        }
    }
}
