using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional5_part1
{
    internal class PhotoBookTest
    {
        public PhotoBook book1;
        public void CreateDefaultPhotoBook(out PhotoBook book)
        {
            book = new PhotoBook();
            Console.WriteLine($"PhotoBook was created. Total pages is {book.GetNumberPages()}");
        }
        public void CreateCustomPhotoBook(out PhotoBook book, int numPages)
        {
            book = new PhotoBook(numPages);
            Console.WriteLine($"PhotoBook was created. Total pages is {book.GetNumberPages()}");
        }
        public void CreateBigPhotoBook(out BigPhotoBook book)
        {
            book = new BigPhotoBook();
            Console.WriteLine($"BigPhotoBook was created. Total pages is {book.GetNumberPages()}");
        }
    }
}
