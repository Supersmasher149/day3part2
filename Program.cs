using System;

namespace New_folder__3_
{
    class Program
    {
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
        }
    }
}
