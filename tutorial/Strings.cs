using System;
namespace Giraffe
{
    class Strings
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            string phrase1 = " is cool";
            int count = phrase.length;

            Console.WriteLine(phrase + phrase1);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Contains("World"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine.IndexOf("Academy");
            Console.WriteLine.Substring(8);
            Console.WriteLine.Substring(8, 3);
            Console.WriteLine(count);
            
            Console.ReadLine();
        }
    }
}