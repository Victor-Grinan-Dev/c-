using System;
namespace Giraffe
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall){
                Console.WriteLine("Yo are a tall male.");

            } else if(isMale && !isTall){
                Console.WriteLine("Yo are a short male.");

            } else if(!isMale && isTall){
                Console.WriteLine("Yo are a tall female.");

            } else {
                Console.WriteLine("Yo are a short male.");

            }

            Console.ReadLine();
        }
    }
}