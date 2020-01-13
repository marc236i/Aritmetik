using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 30;
            int secondnumber = 15;
            int plusNumber = firstNumber + secondnumber;
            int minusNumber = firstNumber - secondnumber;
            int timesNumber = firstNumber * secondnumber;
            int divideNumber = firstNumber / secondnumber;
            Console.WriteLine($"{firstNumber} + {secondnumber} = {plusNumber}");
            Console.WriteLine($"{firstNumber} - {secondnumber} = {minusNumber}");
            Console.WriteLine($"{firstNumber} * {secondnumber} = {timesNumber}");
            Console.WriteLine($"3{firstNumber} / {secondnumber} = {divideNumber}");
        }
    }
}
