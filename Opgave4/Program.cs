using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 10;
            int secondInt = 3;
            double divideDouble = firstInt / secondInt;
            double modulusDouble = firstInt % secondInt;
            Console.WriteLine($"{firstInt} / {secondInt} = {divideDouble}");
            Console.WriteLine($"{firstInt} % {secondInt} = {modulusDouble}");

        }
    }
}
