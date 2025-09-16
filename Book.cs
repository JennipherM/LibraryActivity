using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryActivity
{
    internal class Book
    {
        private string title;
        private string author;
        private string genre;
        private bool hasTranslation;
        private bool isAvailable;

        public Book()
        {
            title = "N/A";
            author = "N/A";
            genre = "N/A";
            hasTranslation = false;
            isAvailable = true;
        }
        public Book(string Title, string Author, string Genre, bool IsAvailable, bool HasTranslation)
        {
            title = Title;
            author = Author;
            genre = Genre;
            hasTranslation = HasTranslation;
            isAvailable = IsAvailable;
        }

        public string Title
        {
            get { return title; }
        }
        public string Author
        {
            get { return author; }
        }
        public string Genre
        {
            get { return genre; }
        }
        public bool HasTranslation
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        public bool IsAvailable
        {
            get { return hasTranslation; }
            set { hasTranslation = value; }
        }


        public void checkOut(Book book)
        {
            if (book.isAvailable)
            {
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Book not available");
            }
        }
        public void checkIn(Book book)
        {
            if (book.isAvailable)
            {
                isAvailable = true;
            }
            else
            {
                Console.WriteLine("Book successfully checked in");
            }
        }

        public void checkForTranslation(Book book)
        {
            if (hasTranslation)
            {
                Console.WriteLine("Book does not have translations");
            }
            else
            {
                Console.WriteLine("Book has translations");
            }
        }

    }
}
