using System;
using System.Collections.Generic;

namespace Learning_CSharp
{
    class Arrays
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Matthew" };
            string newname = "";
            while (newname != "-1")
            {
                Console.WriteLine("What is your name? (-1 to stop)");
                newname = Console.ReadLine();
                if (newname != "-1")
                {
                    names.Add(newname);
                }
            }
            foreach(var name in names)
            {
                Console.WriteLine($"Hello, {name}");
            }
        } 
    }
}