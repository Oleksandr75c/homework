using Additional5_part1;
using System.ComponentModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBookTest test1 = new PhotoBookTest();
            PhotoBook book1;
            BigPhotoBook book2;

            test1.CreateDefaultPhotoBook(out book1);
            test1.CreateCustomPhotoBook(out book1,24);
            test1.CreateBigPhotoBook(out book2);

        }
    }
}