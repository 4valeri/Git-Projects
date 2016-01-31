using System;

class Numbersfrom1toN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int output = 0;

        while (n > output)
        {
            output++;
            Console.Write("{0} ", output);
        }
    }
}

