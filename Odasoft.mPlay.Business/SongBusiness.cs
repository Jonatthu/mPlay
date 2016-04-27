using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    class SongBusiness
    {

        public SongBusiness()
        {

        }
         
        public ICollection<Song> GetSongs()
        {
            var songs = new List<Song>();

            songs.Add(new Song
            {
                Id = 1,
                SongName = "Lose Yourself",
                SongLength = "05:23",
                AlbumId = 1
            });

            songs.Add(new Song
            {
                Id = 2,
                SongName = "Not Afraid",
                SongLength = "04:19",
                AlbumId = 2
            });

            songs.Add(new Song
            {
                Id = 3,
                SongName = "Without Me",
                SongLength = "05:00",
                AlbumId = 3
            });

            songs.Add(new Song
            {
                Id = 4,
                SongName = "Rap God",
                SongLength = "06:10",
                AlbumId = 4
            });

            return songs;
        }

        public Song GetSongById(int SongId)
        {
            return new Song()
            {
                AlbumId = 1,
                Id = 1,
                SongLength = "04:50",
                SongName = "8 Mile"
            };
        }

        public Song CreateSong(Song model)
        {
            return new Song()
            {
                Id = 1,
                SongName = "Mockingbird",
                SongLength = "05:00",
                AlbumId = 1
        };
        }

        public Song EditSong(Song model)
        {
            return new Song()
            {
                AlbumId = 1,
                Id = 1,
                SongLength = "04:50",
                SongName = "8 Mile"
            };
    }

        public void DeleteSongById(int SongId)
        {
            //Delete option
        }

    }
}


