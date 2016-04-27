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
                    SongLength = "4:10",
                    AlbumId = i
                });
            }
            //end of the database

            List<Song> AlbumSongs = songs.FindAll(x => x.AlbumId == AlbumId);

            return AlbumSongs;
        }

        public void DeleteAlbumSongById(int SongId)
        {
            Console.WriteLine("Song Deleted!");
        }





    }

}

