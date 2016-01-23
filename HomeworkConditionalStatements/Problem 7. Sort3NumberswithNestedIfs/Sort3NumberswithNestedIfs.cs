using System;

class Sort3NumberswithNestedIfs
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && b >= c)
        {
            Console.WriteLine("{0} {1} {2}", a,
                b,
                c);
        }

        if (a >= b && a >= c && c >= b)
        {
            Console.WriteLine("{0} {2} {1}", a,
                b,
                c);
        }

        else if (b >= a && b >= c && a >= c)
        {
            Console.WriteLine("{1} {0} {2}", a,
                b,
                c);

        }
        else if (b >= a && b >= c && c >= a)
        {
            Console.WriteLine("{1} {2} {0}", a,
                b,
                c);

        }

        else if (c >= a && c >= b && a >= b)
        {
            Console.WriteLine("{2} {0} {1}", a,
                b,
                c);
        }
        else
        {
            Console.WriteLine("{2} {1} {0}", a,
                b,
                c);
        }
    }
}

