using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAD_MidtermExamReview
{
    //Inehrits the Book class
    public  class Ebook: Book
    {
        //Auto Property for FileSize
        public double FileSize { get; set; }

        //Read only (Full) property for download URL this uses a private string aswell for the return value for the get 
        private string _downloadURL;
        public string DownloadURL 
        { 
            get {  return _downloadURL; }

            
            set
            {
                //Starts with method allows the string to be alltered with text of your choice
                if (value.StartsWith("www."))
                {
                    _downloadURL = value;
                }
                else
                {
                    //Error Handles and throws an exception when 
                    throw new ArgumentException("URL should start with www.");
                }
            }
        }

    }
}
