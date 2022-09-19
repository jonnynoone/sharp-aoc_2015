using System;
public class Advent
{
    public static void Main()
    {
        string input = System.IO.File.ReadAllText("input.txt");
        string[] presents = input.Split("\n");

        int totalRibbon = 0;

        foreach(string present in presents)
        {
            string[] dimensions = present.Split("x");
            
            int length = int.Parse(dimensions[0]);
            int width = int.Parse(dimensions[1]);
            int height = int.Parse(dimensions[2]);
            
            int ribbonWrap = 0;
            if (length >= width && length >= height)
            {
                ribbonWrap = width * 2 + height * 2;
            }
            else if (width >= length && width >= height)
            {
                ribbonWrap = length * 2 + height * 2;
            }
            else if (height >= length && height >= width)
            {
                ribbonWrap = length * 2 + width * 2;
            }

            int ribbonBow = length * width * height;

            int ribbon = ribbonWrap + ribbonBow;
            totalRibbon += ribbon;
        }

        Console.WriteLine(totalRibbon);
    }
}