using System;

public class RectangularBox
{
   public static void Main()
    {
        double length, width, height, area, volume;

        Console.Write("Enter the length of the rectangular box: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangular box: ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the rectangular box: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = length * width;
        volume = area * height;

        Console.WriteLine("The area of the base is: " + area + " square units.");
        Console.WriteLine("The volume of the box is: " + volume + " cubic units.");
    }
}
