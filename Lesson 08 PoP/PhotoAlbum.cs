using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public PhotoAlbum() : this(16)
        {
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
