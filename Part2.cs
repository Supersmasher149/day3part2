using System;

namespace New_folder__3_
{
    class Part2
    {
        public static void Test()
        {
            string[] input = System.IO.File.ReadAllLines("input.txt");
            //Console.WriteLine(input[0]);
            int ymove = 2;
            int xmove = 1;
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
            Console.WriteLine(hit);
        }
    }
}