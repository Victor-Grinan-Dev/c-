using System;
namespace Giraffe
{
    class Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 3);
            Console.WriteLine(2 - 3);
            Console.WriteLine(2 * 3);
            Console.WriteLine(6 / 3);
            Console.WriteLine(2 / 3);
            Console.WriteLine(2 / 3.0);
            Console.WriteLine(2 % 3);
            Console.WriteLine(2 + 3 * 2);
            Console.WriteLine((2 + 3)* 2);

            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(4, 2));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Max(4,9));
            Console.WriteLine(Math.Min(4,9));
            Console.WriteLine(Math.Round(4.9));



            Console.ReadLine();
        }
    }
}