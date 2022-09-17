using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorePractice
{
    public class PhotoBook
    {
        protected int _numPages;
        
        public PhotoBook()
        {
            _numPages = 16;
        }
        public PhotoBook(int pages)
        {
            _numPages = pages;
        }
        public int GetNumberPages()
        {
            return _numPages;
        }
    }
}
