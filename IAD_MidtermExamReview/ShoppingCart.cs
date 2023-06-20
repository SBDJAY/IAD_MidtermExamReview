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
        //Initializes the list "cart" created from the varaibales in the Book Class
        private List <Book> cart = new List<Book> ();  

        //Add Book method which allows the user to add book in the the Cart list 
        public void AddBook(Book book)
        {
            //If else statement which is used to verify if a book object from the list already exists veryfying through the title variable
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
        //This method returns a boolean for wheater or not the title of the book already exists in the cart 
        private bool AlreadyInCart(string title)
        {
            //for each loop is used to calculate for every single book object in the cart list
            foreach (Book book in cart)
            {
                if (book.Title == title)
                {
                    return true;
                }
            }
            return false;
        }
        //returns the count of how many items are in the cart list 
        public int GetCount() 
        {
        //use count without ++ becasue your counting an exisiting object and not something that needs to increase on a click or input event
            return cart.Count;
        }
        //This method takes verifies acn calculates for either a book with a discounted price or a book without the discount
        public double GetTotalPrice(double discountPercentage)
        {
            double totalPrice = 0.0;

            //for each loop is used to calculate for every single book object in the cart list
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
