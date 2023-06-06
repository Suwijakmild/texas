using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of tiles in width (w): ");
        int w = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of tiles in height (h): ");
        int h = int.Parse(Console.ReadLine());

        int totalTiles = w * h;

        if (totalTiles >= 26)
        {
            Console.WriteLine("Too stuffy!");
        }
        else
        {
            Console.WriteLine("Okay!");
        }
    }
}
