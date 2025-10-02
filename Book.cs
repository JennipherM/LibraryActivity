using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

    class Translation : Book 
    {
        public string language;
        public Translation(string Language)
        {
            language = Language;
        }      
    }

    class Accessibility : Book
    {
        public bool isBraille;
        public double fontSize;
        public string fontType;

        public bool isBigFont;
        public bool isDyslexiaFriendly;


        public Accessibility(bool braille, double FontSize, string FontType)
        {
            isBraille = braille;
            fontSize = FontSize;
            fontType = FontType;
        }
        public void checkForAccessibility(Accessibility book)
        {
            if (book.fontSize > 18)
            {
                isBigFont = true;
            }
            else
            {
                isBigFont = false;
            }

            if (book.fontType == "Comic Sans" ||  book.fontType == "Calibri" || book.fontType == "Verdana")
            {
                isDyslexiaFriendly = true;
            }
            else
            {
                isDyslexiaFriendly = false;
            }


        }
        public void printAccess(Accessibility book)
        {
            Console.WriteLine($"Braille: {book.isBraille}  Big Font: {book.isBigFont}  Dyslexia Friendly: {book.isDyslexiaFriendly}");
        }

    }

    class Fees : Book
    {
        public double feePrice;
        public int daysLate;
        public double amount;

        public Fees(int days)
        {
            feePrice = 2.99;
            daysLate = days;
        }

        public void calculateFee(Fees book)
        {
            amount = feePrice * daysLate;
        }
    }
}
