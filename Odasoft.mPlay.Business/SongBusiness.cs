using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    public class SongBusiness
    {

        public SongBusiness()
        {

        }
         
        public ICollection<Song> GetSongs()
        {
            var songs = new List<Song>();

            for(int i = 0; i < 10; i++)
                for(int j = i*10; j < i*10+10; j++)
                    songs.Add(new Song
                    {
                        Id = j,
                        SongName = "Lose Yourself",
                        SongLength = "05:23",
                        AlbumId = i
                    });

            return songs;
        }

        public ICollection<Song> GetSongsByAlbumId(int AlbumId)
        {
            var songs = this.GetSongs().ToList();
            var AlbumSongs = songs.FindAll(x => x.AlbumId == AlbumId);
            return AlbumSongs;
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


