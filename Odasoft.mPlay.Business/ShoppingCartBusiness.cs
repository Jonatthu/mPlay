using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    public class ShoppingCartBusiness
    {
        public ShoppingCartBusiness()
        {

        }

        public ICollection<Album> GetShoppingCartAlbumsById(int Id)
        {
            var songs = new List<Song>();
            songs.Add(new Song
            {
                Id = 1,
                AlbumId = 1,
                SongLength = "4:05",
                SongName = "Song Name"
            });

            var items = new List<Album>();
            items.Add(new Album
            {
                Id = 1,
                Author = "Jonatthu",
                Description = "asdasdsadasdasdsadsadsad",
                Genre = "string",
                Image = "imageurl",
                Length = "1",
                Price = 120,
                ReleaseDate = DateTime.Now,
                Title = "A title",
                Songs = songs
            });

            return items;
        }

        public ICollection<Movie> GetShoppingCartMoviesById(int Id)
        {
            var movies = new List<Movie>();
            movies.Add(new Movie
            {
                Id = 1,
                Title = "Titanic",
                Author = "Bla BLa",
                ReleaseDate = DateTime.Now,
                Genre = "Romantic",
                Price = 45,
                Description = "Titanic sinks",
                Length = "2:45",
                Image = "URL"

            });

            return movies;
        }


    }

    
}
