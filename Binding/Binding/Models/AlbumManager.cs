using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding.Models
{
    public class AlbumManager
    {
        public static List<Albums> GetAlbums()
        {
            List<Albums> albums = new List<Albums>();

            albums.Add( new Albums
            {
                AlbumID = 1,
                Title = "At San Quentin",
                Artist = "Johnny Cash",
                CoverImage = "Assets/1.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 2,
                Title = "I walk the line",
                Artist = "Johnny Cash",
                CoverImage = "Assets/2.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 3,
                Title = "At Folsom Prison",
                Artist = "Johnny Cash",
                CoverImage = "Assets/3.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 4,
                Title = "The Fabulous Johnny Cash",
                Artist = "Johnny Cash",
                CoverImage = "Assets/4.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 5,
                Title = "Man In Black",
                Artist = "Johnny Cash",
                CoverImage = "Assets/5.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 6,
                Title = "The Legend of Johnny Cash",
                Artist = "Johnny Cash",
                CoverImage = "Assets/6.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 7,
                Title = "The Essential Johnny Cash",
                Artist = "Johnny Cash",
                CoverImage = "Assets/7.jpg"
            });

            albums.Add(new Albums
            {
                AlbumID = 8,
                Title = "American Recordings",
                Artist = "Johnny Cash",
                CoverImage = "Assets/8.jpg"
            });

            return albums;
        }
    }
}
