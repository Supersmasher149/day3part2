using System;

namespace New_folder__3_
{
    class Program
    {
        string[] lines = System.IO.File.ReadAllLines("input.txt");
        public static int Encounter(string[] input, int xmove, int ymove)
        {
            //string[] input = System.IO.File.ReadAllLines("input.txt");
            //Console.WriteLine(input[0]);
            //int ymove = 2;
            //int xmove = 1;
            int x = 0;
            int hit = 0;
            
            for (int i = ymove; i < input.Length; i++)
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
            return hit;
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
            //Console.WriteLine(hit);
            //New_folder__3_.Part2.Test();
            //New_folder__3_.Program.Encounter(3, 1);
            Console.WriteLine(Encounter(input, 1, 1) * Encounter(input, 3, 1) * Encounter(input, 5, 1) * Encounter(input, 7, 1) * Encounter(input, 1, 2));
            //Console.WriteLine(Encounter(input, 3, 1));
        }
    }
}
