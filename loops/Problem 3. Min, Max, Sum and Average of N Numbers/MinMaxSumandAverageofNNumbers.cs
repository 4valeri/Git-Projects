using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumandAverageofNNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int[] array = new int[input];

        for (int i = 0; i < input; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }

        List<int> list = new List<int>(array);


        Console.WriteLine(list.Min());
        Console.WriteLine(list.Max());
        Console.WriteLine(list.Sum());
        Console.WriteLine("{0:f2}", list.Average());



        //foreach (var numbers in array)
        //{
        //    Console.Write(numbers + " ");
        //}

        //Console.WriteLine();


    }
}

