using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($@"Testing \n 1 2 {5 - 2}
New line");

            // Console.ReadKey();
            var multilineWithDoubleQuotes = @"I went to a city named
    ""San Diego""
            during summer vacation.";

            Console.WriteLine(multilineWithDoubleQuotes);


        }
    }
}
