using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    class MovieBusiness
    {
        public MovieBusiness()
        {

        }

        public ICollection<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            //Movies generated locally
            for (int i = 0; i < 10; i++)
            {
                movies.Add(new Movie
                {
                    Id = i,
                    Title = "Abc",
                    Author = "Name",
                    ReleaseDate = DateTime.Today.Date,
                    Genre = "Category",
                    Price = 4.99m,
                    Description = "abcdf",
                    Length = "1:50:20",
                    Image = "Ruta"
                });
            }

            return movies;
        }

        public Movie GetMovieById(int MovieId)
        {
            List<Movie> movies = this.GetMovies().ToList();

            var MovieById = movies.FindAll(x => x.Id == MovieId).FirstOrDefault();

            return MovieById;
        }

        public Movie CreateMovie(Movie model)
        {
            //this function will create a movie in the db
            return new Movie
            {
                Id = 1,
                Title = "Abc",
                Author = "Name",
                ReleaseDate = DateTime.Today.Date,
                Genre = "Category",
                Price = 4.99m,
                Description = "abcdf",
                Length = "1:50:20",
                Image = "Ruta"
            };
        }

        public Movie EditMovie(Movie model)
        {
            //this function will edit a movie in the db
            return new Movie
            {
                Id = 1,
                Title = "Abc",
                Author = "Name",
                ReleaseDate = DateTime.Today.Date,
                Genre = "Category",
                Price = 4.99m,
                Description = "abcdf",
                Length = "1:50:20",
                Image = "Ruta"
            };
        }

        public void DeleteMovie(int AlbumId)
        {
            //this function will delete a movie in the db
        }
    }
}
