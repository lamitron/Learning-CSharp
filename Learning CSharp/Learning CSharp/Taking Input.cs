﻿using System;

namespace Learning_CSharp
{
    class TakingInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello there {name}");
            Console.WriteLine($"{name}, do you like my program?");
            string opinion = Console.ReadLine();
            opinion = opinion.ToLower
            if (opinion[1] == 'y')
            {
                Console.WriteLine("Thanks! :)");
            }
            else if (opinion[1] == 'n')
            {
                Console.WriteLine("Sorry, please tell me what I could do to improve :'(");
            }
        }
    }
}