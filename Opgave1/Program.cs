using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = ("12");
            string secondString = ("34");
            int firstInt = 12;
            int secondInt = 34;
            string stringResult = firstString + secondString;
            int intResult = firstInt + secondInt;
            Console.WriteLine($"Tekst lagt sammen er: {stringResult}");
            Console.WriteLine($"Tal lagt sammen er: {intResult}");
            Console.WriteLine($"Tekst og tal lagt sammen er: {stringResult + intResult}");
        }
    }
}
