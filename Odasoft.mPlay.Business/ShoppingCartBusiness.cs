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
        //PROPERTIES
        public ICollection<Movie> moviesInCart;
        private readonly AlbumBusiness _AlbumBusiness;
        //CONSTRUCTOR
        public ShoppingCartBusiness(AlbumBusiness AlbumBusiness)
        {
            this._AlbumBusiness = AlbumBusiness;
            moviesInCart = GetShoppingCartMoviesById(1);
        }
        //METHODS
        public ICollection<Album> GetShoppingCartAlbumsById(int ShoppingCartId)
        {

            return this._AlbumBusiness.GetAlbums();
                  
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
