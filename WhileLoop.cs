using System;
namespace Giraffe
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(Index);
                index++;
            }

            Console.ReadLine();
        }

        static void WhileLoop(int num)
        {
            int index = 1;
            while(index <= num)
            {
                Console.WriteLine(Index);
                index++;
            }

            Console.ReadLine();
        }

        static void DoWhileLoop(int num)
        {
            int index = 1;
            do
            {
                Console.WriteLine(Index);
                index++;
            } while(index <= num)

            Console.ReadLine();
        }
    }
}