using System;
namespace Giraffe
{
    class Methods
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);

            Console.ReadLine();
        }

        static void SayHi(strin name, int age)
        {
            Console.ReadLine("Hello, " + name + "! You are " + age + " old.");
        }
    }
}