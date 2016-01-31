using System;

class NumbersNotDivisibleby3and7
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int output = 0;

        while (n > output)
        {
            output++;
            if (output % 3 == 0)
            {
                continue;

            }
            else if (output % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", output);

        }

    }

}

