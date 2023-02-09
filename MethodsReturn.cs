using System;
namespace Giraffe
{
    class MethodReturn
    {
        static void Main(string[] args)
        {
            console.WriteLine(cube(5));
            console.WriteLine(cube(2));
            console.WriteLine(cube(10));

            Console.ReadLine();
        }

        static int cube(int num)
        {
            return num * num * num;
        }
    }
}