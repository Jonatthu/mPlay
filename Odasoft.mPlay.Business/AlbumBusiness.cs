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
                string description = "Recovery is the seventh studio album by American rapper Eminem. It was released on June 18, 2010, by Shady Records, Aftermath Entertainment and Interscope Records as the follow-up to Eminem's Relapse (2009). Originally planned to be released as Relapse 2, the album was renamed to Recovery when Eminem found the music of the new album different from its predecessor.";
                string[] albumsA = { "Recovery", "Marshall Mathers LP 2", "Marshall Mathers LP", "Slim Shady", "Relapse", "Encore", "Infinite", "The Eminem Show", "Curtain Call","Underground" };
                string[] imagesA = {
                "https://tartillos.files.wordpress.com/2011/07/eminem-recovery-official-album-cover.jpg",
                "https://upload.wikimedia.org/wikipedia/en/a/ae/The_Marshall_Mathers_LP.jpg",
                "https://upload.wikimedia.org/wikipedia/en/6/69/The_Marshall_Mathers_LP_second_cover.jpg",
                "https://upload.wikimedia.org/wikipedia/en/3/35/Eminem_-_The_Slim_Shady_LP_CD_cover.jpg",
                "https://upload.wikimedia.org/wikipedia/en/4/42/Relapse_(album).jpg",
                "https://upload.wikimedia.org/wikipedia/en/b/b4/Encore_(Eminem_album)_coverart.jpg",
                "http://ecx.images-amazon.com/images/I/51Y6eiq0MwL.jpg",
                "https://upload.wikimedia.org/wikipedia/en/3/35/The_Eminem_Show.jpg",
                "https://upload.wikimedia.org/wikipedia/en/4/4e/Curtain_Call_cover.jpg",
                "http://eminem.wbs.cz/fotogalerie/2/velke/2nktcmf.jpg"
                };

                items.Add(new Album
                {
                    Id = j,
                    Author = "Eminem",
                    Description = description,
                    Genre = "Hip Hop",
                    Image = imagesA[j],
                    Length = "05:23",
                    Price = 120,
                    ReleaseDate = DateTime.Now,
                    Title = albumsA[j]
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

