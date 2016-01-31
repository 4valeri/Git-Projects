﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Binary_to_Decimal_Number
{
    class BinarytoDecimalNumber
    {
        static void Main()
        {
            string binNumber = Console.ReadLine();
            long decNumber = 0;
            int power = 1;

            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int num = binNumber[i] - 48;
                decNumber += num * power;
                power *= 2;
            }
            Console.WriteLine(decNumber);
        }
    }
}
