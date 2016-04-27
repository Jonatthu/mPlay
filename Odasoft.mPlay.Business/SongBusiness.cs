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
         
        public ICollection<Song> GetSongById(int AlbumId)
        {
            var songs = new List<Song>();

            songs.Add(new Song
            {
                Id = 1,
                SongName = "Lose Yourself",
                SongLength = "5:23",
                AlbumId = 1
            });

            songs.Add(new Song
            {
                Id = 2,
                SongName = "Not Afraid",
                SongLength = "4:19",
                AlbumId = 2
            });

            songs.Add(new Song
            {
                Id = 3,
                SongName = "Without Me",
                SongLength = "5:00",
                AlbumId = 3
            });

            songs.Add(new Song
            {
                Id = 4,
                SongName = "Rap God",
                SongLength = "6:10",
                AlbumId = 4
            });

            return songs;
        }

        /*public ICollection<Song> EditSongById(Song model)
        {

        }*/

    }
}
