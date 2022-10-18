using System;

class Program {
  public static void Main (string[] args) {

    string[] months = new string[12]
    {"jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

    Random rnd = new Random();

    int month = rnd.Next(1, 13);

    Console.WriteLine("Month is {0}", months[month-1]);
  }
}