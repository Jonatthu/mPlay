using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    public class AlbumBusiness
    {
        private readonly SongBusiness _SongBusiness;
        public AlbumBusiness(SongBusiness SongBusiness)
        {
            this._SongBusiness = SongBusiness;
        }

        public int NumberOfAlbums()
        {
            return this.GetAlbums().Count;
        }

        public ICollection<Album> GetAlbums()
        {
            var items = new List<Album>();
            for (int j = 0; j < 10; j++)
            {
                string imageurl = "http://s3.foxfilm.com/foxmovies/production/films/96/images/gallery/revenant-gallery-20-gallery-image.jpg";
                items.Add(new Album
                {
                    Id = j,
                    Author = "Guillermo Del Toro",
                    Description = "Great Thriller",
                    Genre = "Action",
                    Image = imageurl,
                    Length = "1",
                    Price = 120,
                    ReleaseDate = DateTime.Now,
                    Title = "The Revenant"
                });


            }

            return items;
        }


        public Album GetAlbumById(int AlbumId)
        {

            var Album = this.GetAlbums().ToList()
                .FindAll(x => x.Id == AlbumId).FirstOrDefault();

            Album.Songs = this._SongBusiness.GetSongsByAlbumId(AlbumId);

            return Album;
        }

        public ICollection<Song> GetAlbumSongsById(int AlbumId)
        {
            //The id parameter is from the Album Id

            //This is what will actually come from the database
            var songs = new List<Song>();

            for (int i = 0; i < 10; i++)
            {
                songs.Add(new Song
                {
                    Id = i,
                    SongName = "whatever",
                    SongLength = "04:10",
                    AlbumId = i
                });
            }
            //end of the database

            List<Song> AlbumSongs = songs.FindAll(x => x.AlbumId == AlbumId);

            return AlbumSongs;
        }

        public Album EditAlbum(Album Album)
        {
            Console.WriteLine("Album Edited");

            return Album;

        }

        public void DeleteAlbumSongById(int SongId)
        {
            Console.WriteLine("Song Deleted!");
        }

        public string GetAlbumLengthById(int AlbumId)
        {
            int secondTotal = 0;
            int minuteTotal = 0;
            int hourTotal = 0;
            string albumLength = " ";
            ICollection<Song> songs = GetAlbumSongsById(AlbumId);


            foreach (Song song in songs)
            {
                string str = song.SongLength;
                string minutes = str.Substring(0, 3);
                string seconds = str.Substring(4, 6);

                int mins = Int32.Parse(minutes);
                int secs = Int32.Parse(seconds);

                minuteTotal += mins;
                secondTotal += secs;

                if (minuteTotal >= 60)
                {
                    hourTotal += 1;
                    minuteTotal -= 60;
                }

            }
            albumLength = hourTotal.ToString() + ":" + minuteTotal.ToString();

            return albumLength;
        }




    }

}

