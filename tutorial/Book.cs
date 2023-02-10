using System;
using System.Collection.Generics;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Giraffe
{
    class Book
    {
        public string title;
        public string aithor;
        public int pages;

        public Book()
        {
            Console.WriteLine("Creating book")
        }
        public Book(string atitle, string aAuthor, string aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}