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
        ExtractSubString();
        ConcatenatingTwoStrings();
        ConversionPointNumber();
        CoversionInteger();
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

    public static void ExtractSubString()
    {
        string month = "January";
        string subString;
        int startPos = 3;
        int howMany = 2;

        subString = month.Substring(startPos, howMany);
        Console.WriteLine("Substring is {0}", subString);
    }

    public static void ConcatenatingTwoStrings()
    {
        string month = "January";
        string saying = " has 31 days.";
        string combined;

        combined = month + saying;
        Console.WriteLine("Joined string is {0}", combined);
    }

    public static void ConversionPointNumber()
    {
        string mystring = "123.45";
        float mynumber = 0;

        mynumber = float.Parse(mystring);
        Console.WriteLine("My number, 100 times bigger is {0}", mynumber * 100);
    }

    public static void CoversionInteger()
    {
        string mystring = "123";
        int mynumber = 0;

        mynumber = int.Parse(mystring);
        Console.WriteLine("My number, subtract 1 is {0}", mynumber - 1);
    }
}