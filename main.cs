using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string[] months = new string[12]
        {"jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

        Random rnd = new Random();

        int month = rnd.Next(1, 13);

        Console.WriteLine("Month is {0}", months[month - 1]);
        RangeTest();

    }

    public static void RangeTest()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

        foreach (int num in squares)
        {
            Console.WriteLine(num);
        }
    }
}