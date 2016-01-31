using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Random_Numbers_in_Given_Range
{
    class RandomNumbersinGivenRange
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int minInt = int.Parse(Console.ReadLine());
            int maxInt = int.Parse(Console.ReadLine());
            if (minInt <= maxInt)
            {
                Random random = new Random();
                for (int index = 0; index < count; index++)
                {
                    Console.Write("{0} ", random.Next(minInt, maxInt + 1));
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}
