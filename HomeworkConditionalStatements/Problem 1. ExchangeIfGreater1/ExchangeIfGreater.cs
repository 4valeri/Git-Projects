﻿using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            Console.WriteLine("{1} {0}", a,
                b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a,
                b);
        }
    }
}

