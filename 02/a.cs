using System;
public class Advent
{
    public static void Main()
    {
        string input = System.IO.File.ReadAllText("input.txt");
        string[] presents = input.Split("\n");
        
        int totalPaper = 0;

        foreach(string present in presents)
        {
            string[] dimensions = present.Split("x");
            
            int length = int.Parse(dimensions[0]);
            int width = int.Parse(dimensions[1]);
            int height = int.Parse(dimensions[2]);

            int[] sides = new int[3];
            sides[0] = 2 * length * width;
            sides[1] = 2 * length * height;
            sides[2] = 2 * width * height;

            int surfaceArea = sides[0] + sides[1] + sides[2];

            int smallestSide = 0;
            if (sides[0] <= sides[1] && sides[0] <= sides[2])
            {
                smallestSide = sides[0] / 2;
            }
            else if (sides[1] <= sides[0] && sides[1] <= sides[2])
            {
                smallestSide = sides[1] / 2;
            }
            else if (sides[2] <= sides[0] && sides[2] <= sides[1])
            {
                smallestSide = sides[2] / 2;
            }

            int paper = surfaceArea + smallestSide;
            totalPaper += paper;
        }

        Console.WriteLine(totalPaper);
    }
}