﻿using Odasoft.mPlay.Models;
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
            string[] songsA = { "Lose Yourself", "No Love", "Rap God", "Mocking Bird", "Beautiful", "Not Afraid", "8 Mile", "Headlights", "My name is", "When Im Gone" };
            
            for (int i = 0; i < 10; i++)
            {
                int k = 0;
                for (int j = i * 10; j < i * 10 + 10; j++)
                {
                        songs.Add(new Song
                        {
                            Id = j,
                            SongName = songsA[k],
                            SongLength = "05:23",
                            AlbumId = i
                        });
                    k++;
                }
            }

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


