﻿using System;

class TheBiggestof3Numbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }

        else if (b >= a && b >= c)
        {
            Console.WriteLine(b);

        }

        else
        {
            Console.WriteLine(c);
        }

    }
}

