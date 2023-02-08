using System;
namespace Giraffe
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};

            Console.WriteLine(luckyNumbers[0]);

            luckyNumbers[0] = 900;
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Kelly";


            Console.ReadLine();
        }
    }
}