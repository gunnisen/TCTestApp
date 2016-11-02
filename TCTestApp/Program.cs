using System;

namespace TCTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TCTestLib.DataProvider.Greeting());
            Console.ReadLine();
        }
    }
}
