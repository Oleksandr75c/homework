using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional5_part1
{
    internal class BigPhotoBook
    {
        private int numPages { get; set; }
        public Image[] photo { get; set; }

        public BigPhotoBook()
        {
            this.numPages = 64;
            photo = new Image[this.numPages];
        }
        public int GetNumberPages()
        {
            return this.numPages;
        }
    }
}
