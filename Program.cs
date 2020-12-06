using System;

namespace New_folder__3_
{
    class Program
    {
        string[] input = System.IO.File.ReadAllLines("input.txt");
        static void Encounter(string[] input, int ymove, int xmove)
        {
            int x = 0;
            int hit = 0;
            for (int i = ymove; i < input.Length; i = i + ymove)
            {
                if ()
            }
        }
        static void Main()
        {
            string[] input = System.IO.File.ReadAllLines("input.txt");
            //Console.WriteLine(input[0]);

            int xmove = 3;
            int x = 0;
            int hit = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (xmove + x >= input[0].Length)
                {
                    x = xmove + x - input[0].Length;
                }
                else
                {
                    x = xmove + x;
                }
                if (input[i][x] == '#')
                {
                    hit++;
                }
                //Console.WriteLine(input[i]);
            }
            Console.WriteLine(hit);
            New_folder__3_.Part2.Test();
        }
    }
}
