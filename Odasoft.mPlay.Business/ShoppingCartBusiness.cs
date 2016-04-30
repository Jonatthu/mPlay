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
        public ICollection<Movie> moviesInCart;

        public ShoppingCartBusiness()
        {
            moviesInCart = GetShoppingCartMoviesById(1);
        }

        public ICollection<Album> GetShoppingCartAlbumsById(int ShoppingCartId)
        {
            
            
            var items = new List<Album>();
            for (int j=0;j<10;j++)
            {


                var songs = new List<Song>();
                for (int i = 0; i < 10; i++)
                {
                    songs.Add(new Song
                    {
                        Id = i,
                        AlbumId = 1,
                        SongLength = "4:05",
                        SongName = "Song Name"
                    });
                }

                
    
                string imageurl = "http://s3.foxfilm.com/foxmovies/production/films/96/images/gallery/revenant-gallery-20-gallery-image.jpg";
                items.Add(new Album
                {
                    
                    Id = 1,
                    Author = "Guillermo Del Toro",
                    Description = "Great Thriller",
                    Genre = "Action",
                    Image = imageurl,
                    Length = "1",
                    Price = 120,
                    ReleaseDate = DateTime.Now,
                    Title = "The Revenant",
                    Songs = songs
                });


            }
            
            return items;
        }

        public ICollection<Movie> GetShoppingCartMoviesById(int ShoppingCartId)
        {
            var movies = new List<Movie>();

            for (int i=0;i<10;i++)
            {
                string imageurl = "http://s3.foxfilm.com/foxmovies/production/films/96/images/gallery/revenant-gallery-20-gallery-image.jpg";
                movies.Add(new Movie
                {
                    Id = i,
                    Title = "The Revenant",
                    Author = "Guillermo Del Toro",
                    ReleaseDate = DateTime.Now,
                    Genre = "Action",
                    Price = 45,
                    Description = "Great thriller",
                    Length = "2:45",
                    Image = imageurl

                });
            }
            
            return movies;
        }

        public void removeMovieById(int MovieId)
        {
           var  movie = moviesInCart.ElementAt(MovieId);
            moviesInCart.Remove(movie);
        }
      


    }

    
}
