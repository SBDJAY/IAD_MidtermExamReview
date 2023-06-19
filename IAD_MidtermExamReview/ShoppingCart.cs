using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IAD_MidtermExamReview
{
    public class ShoppingCart
    {
        private List <Book> cart = new List<Book> ();  

        public void AddBook(Book book)
        {
            if (!AlreadyInCart(book.Title))
            {
                cart.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the cart.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is already in the cart.");
            }
        }

        private bool AlreadyInCart(string title)
        {
            foreach (Book book in cart)
            {
                if (book.Title == title)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetCount() 
        {
            return cart.Count;
        }

        public double GetTotalPRice(double discountPercentage)
        {
            double totalPrice = 0.0;

            foreach (Book book in cart)
            {
                double bookPrice = book.BasePrice + book.ExtraCost;
                totalPrice += bookPrice;
            }

            double discountAmount = totalPrice * discountPercentage;
            double discountedTotalPrice = totalPrice - discountAmount;

            return discountedTotalPrice;
        }

    }
}
