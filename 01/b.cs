using System;
public class Advent
{
    public static void Main()
    {
        int floor = 0;
        string input = System.IO.File.ReadAllText("input.txt");
        int inputLength = input.Length;
        
        for (int i = 0; i < inputLength; i++)
        {
            if (input[i] == '(')
            {
                floor++;
            }
            else if (input[i] == ')')
            {
                floor--;
            }

            if (floor == -1) 
            {
                Console.WriteLine(i + 1);
                break;
            }
        }
    }
}