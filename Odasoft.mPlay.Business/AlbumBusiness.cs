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
        public AlbumBusiness()
        {

        }

        public ICollection<Album> GetAlbums()
        {
            var Albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                Albums.Add(new Album());
            }

            return Albums;
        }
        public Album GetAlbumById(int AlbumId)
        {
            var Album = new Album({
                
                Author = "Me",
                Description = "Great Album",
                Genre = "Terror",
                Id = 1,
                Image = "Hello World",
                Length = "04:05"
            });

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

