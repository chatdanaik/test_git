using System;

class BooleanExample
{
    static void Main(string[] args)
    {

        bool isDay = true;

        if (isDay)
        {
            Console.WriteLine("Good morning.");
        }
        else
        {
            Console.WriteLine("Good night.");
        }

        bool gameOver = false;
        Console.WriteLine("Game over = {0}", gameOver);

    }
}