using System;

class PlaywithIntDoubleandString
{
    static void Main(string[] args)
    {
        Console.WriteLine("@Please choose a type:\n1-- > int\n2-- > double\n3-- > string");

        int i = int.Parse(Console.ReadLine());
        //double d = double.Parse(Console.ReadLine());
        //string s = (Console.ReadLine());

        switch (i)
        {
            case 1:
                Console.WriteLine("Please enter a integer:");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", integer + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", d + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine("{0}*", str);
                break;
            default:
                Console.WriteLine("Choose 1,2 or 3!");

               
                break;    
        }



    }
}

