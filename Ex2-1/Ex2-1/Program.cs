﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 4; b++)
                {
                    for (c = 1; c <= 4; c++)
                    {
                        if (a != b &&a!=c &&b!=c)
                        {
                            d = 10 - a - b - c;
                            if ((c == 1 ^ b == 2) && (c==2^d==3)&&(a==2^d==4))
                            {
                                Console.Write("红球放置在{0}号，黄球放置在{1}号,", a, b);
                                Console.Write("黑球放置在{0}号，白球放置在{1}号", c, d);
                            }
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
