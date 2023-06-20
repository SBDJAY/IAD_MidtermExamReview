using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAD_MidtermExamReview
{
    public class Book
    {
        //Title Auto Property
        public string Title { get; set; }
        //IsHardCover Auto Property( Used for True or False
        public bool IsHardCover { get; set; }

        //Read only property for the base price so the base price can not be altered or changed 
        private double _basePrice;
        public double BasePrice
        {
            get { return _basePrice; }

            set
            {
                if (value > 0)
                {
                    _basePrice = value;
                }

                else
                {
                    //throws exception if the Price of the book is not greater then zero and is 
                    throw new Exception("PRice has to be a positive numeber greater then 0");
                }
            }
        }
                
        // The extra cost uses a ternary operator to verify based of the IsHardCover boolean wheater a discount should or should not be applied
        public double ExtraCost
        {
            get { return IsHardCover ? 10.0 : 5.0; }
        }
    }
}
