using System;
namespace Giraffe
{
    class Inputs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!\nYou are " + age);

            Console.ReadLine();
        }
    }
}