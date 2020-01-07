using System;

namespace Learning_CSharp
{
    class Numbers
    {
        static void Main(string[] args)
        {
            /*int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine(max);
            Console.WriteLine(min);*/
            var max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            int counter = 0;
            /*while (true)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;  
            }*/
            Console.WriteLine(DateTime.Now);
        }
    }
}