using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("title", "author", "genre", true, false);

            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Title+ book2.Author+ book2.Genre+ book2.IsAvailable+ book2.HasTranslation);

            //Inheritance
            Translation translatedBook = new Translation("Spanish");
            Console.WriteLine($"Title: {translatedBook.Title}   Language Option: {translatedBook.language}");

            Accessibility accessBook = new Accessibility(false, 18.3, "Ariel");
            Console.WriteLine($"Title: {accessBook.Title}");
            accessBook.checkForAccessibility(accessBook);
            accessBook.printAccess(accessBook);


            Fees feesBook = new Fees(3);
            feesBook.calculateFee(feesBook);
            Console.WriteLine($"Title: {feesBook.Title}   Fee Amount: {feesBook.amount}");
        }
    }
}
