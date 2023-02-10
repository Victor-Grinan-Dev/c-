using System;
namespace Giraffe
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            ForLoop(5);
            int[] luckyNumber = {12,16,23,55};
            ReadArray(luckyNumber);

            Console.ReadLine();
        }

        static void ForLoop(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        static void ReadArray(int[] array)
        {
             
            for (int i = 1; i < array.length; i++)
            {
                Console.WriteLine(luckyNumber[i]);
            }
            
        }
    }
}