using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Business
{
    class AlbumBusiness
    {
        public AlbumBusiness()
        {

        }

        public ICollection<Song> GetSongById(int Id)
        {
            var songs = new List<Song>();
            songs.Add(new Song
            {
                Id = 1,
                Album = new Album(),
                SongName = "whatever",
                SongLength = "4:10"

            });

            return songs;
        }
    }

}

