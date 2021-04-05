using System;
class NumberExsample
{
    static void Main (string[] args)
    {
        int apple = 10;
        int mango = 5;
        int totalFruit = apple + mango;

        Console.WriteLine("We have {0} fruits in the basket", totalFruit);

        byte month = 12;
        byte day = 10;
        short year = 2016;
        
        Console.WriteLine("Date {0}/{1}/{2}", month, day, year);

        decimal bigNumber = 9460730472580800;
        Console.WriteLine(bigNumber.ToString("0.00000E0"));

        int max = Int32.MaxValue;
        Console.WriteLine(max);
        max = max + 1;
        Console.WriteLine(max);
    }
}