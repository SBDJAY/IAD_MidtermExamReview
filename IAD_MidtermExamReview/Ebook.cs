using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAD_MidtermExamReview
{
    public  class Ebook: Book
    {
        public double FileSize { get; set; }
        private string downloadURL;
        public string DownloadURL 
        { 
            get {  return downloadURL; }

            
            set
            {
                if (value.StartsWith("www."))
                {
                    downloadURL = value;
                }
                else
                {
                    throw new ArgumentException("URL should start with www.");
                }
            }
        }

    }
}
