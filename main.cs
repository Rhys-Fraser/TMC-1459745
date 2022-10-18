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
        RoundTest();
        TruncateTest();
        GetLengthOfString("Rhys Fraser");
        GetCharOfString("Rhys Fraser", 5);
    }

    public static void RangeTest()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

        foreach (int num in squares)
        {
            Console.WriteLine(num);
        }
    }

    public static void RoundTest()
    {
        float originalNumber1 = 1.23f;
        float originalNumber2 = 3.15f;
        float originalNumber3 = 1.9f;

        float roundedNumber1 = (float)Math.Ceiling(originalNumber1);
        float roundedNumber2 = (float)Math.Round(originalNumber2, 1);
        float roundedNumber3 = (float)Math.Floor(originalNumber3);

        Console.WriteLine("roundedNumber1 is " + roundedNumber1);
        Console.WriteLine("roundedNumber2 is " + roundedNumber2);
        Console.WriteLine("roundedNumber3 is " + roundedNumber3);
    }

    public static void TruncateTest()
    {
        decimal decimalNumber;

        decimalNumber = 32.7865m;

        Console.WriteLine(Math.Truncate(decimalNumber));

        decimalNumber = -32.9012m;

        Console.WriteLine(Math.Truncate(decimalNumber));
    }

    public static void GetLengthOfString(string str)
    {
        int length;

        length = str.Length;
        Console.WriteLine("{0} is {1} characters long", str, length);
    }

    public static void GetCharOfString(string str, int i)
    {
        char singleLetter;

        singleLetter = str[i];
        Console.WriteLine("Character {0} of {1} is {2}", i, str, singleLetter);
    }
}