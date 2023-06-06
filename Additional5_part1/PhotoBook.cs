using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional5_part1
{
    internal class PhotoBook
    {
        private int numPages { get; set; }
        public Image[] photo { get; set; }

        public PhotoBook()
        { 
            this.numPages = 16;
            photo = new Image[this.numPages];
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
            photo = new Image[this.numPages];
        }
        public int GetNumberPages() 
        { 
            return this.numPages;
        }
    }
}
