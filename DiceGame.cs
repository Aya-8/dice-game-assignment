using System;

public class DiceGame
{
    static void Main()
    {
        Random random = new Random();

        int dice_1 = random.Next(1, 7);
        int dice_2 = random.Next(1, 7);
        int total = dice_1 + dice_2;

        Console.WriteLine("Rolling dice...");
        Console.WriteLine("Die 1:" + dice_1);
        Console.WriteLine("Die 2:" + dice_2);
        Console.WriteLine("Total value: " + total);


        
    }

}