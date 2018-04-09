using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.Models
{
    public class Albums
    {
        private int albumID;
        public int AlbumID { get => albumID; set => albumID = value; }

        private string title;
        public string Title { get => title; set => title = value; }

        private string artist;
        public string Artist { get => artist; set => artist = value; }

        private string coverImage;
        public string CoverImage { get => coverImage; set => coverImage = value; }

    }
}
