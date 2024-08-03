using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task1
{
    internal class Book
    {
        public string author;
        public string nameBook;
        public string yearPublication;
        public Book() { author = "Galahan"; nameBook = "Dyne"; }
        public Book(string author, string nameBook) { }

        public Book(string author, string nameBook, string yearPublication) : this(author, nameBook)
        {
            this.yearPublication = yearPublication;
        }
    }
}
