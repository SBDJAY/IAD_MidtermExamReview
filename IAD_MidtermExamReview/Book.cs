using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAD_MidtermExamReview
{
    public class Book
    {
        public string Title { get; set; }
        public bool IsHardCover { get; set; }

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
                    throw new Exception("PRice has to be a positive numeber greater then 0");
                }
            }
        }
                
        
        public double ExtraCost
        {
            get { return IsHardCover ? 10.0 : 5.0; }
        }
    }
}
