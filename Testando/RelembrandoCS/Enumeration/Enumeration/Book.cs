using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _pages;
        private int _wordCount;

        public Book(string title, string author)
        {
            this._title = title;
            this._author = author;
        }
    }
}
