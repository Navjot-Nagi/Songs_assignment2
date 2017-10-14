using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NNSongsWebAPI.Models
{
    public class SongList
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song { SongID = 1, Title = "Despacito", AlbumName = "Despacito", Artist = "Luis Fonsi", Genre = "Reggaeton"},
            new Song { SongID = 2, Title = "Do you know", AlbumName = "Do you know", Artist = "Diljit Dosanjh", Genre = "Punjabi Bhangra romentic pop sikh"},
            new Song { SongID = 3, Title = "Aise na mujhe tum dekho", AlbumName = "DJ Suketu & Friends Present RD Burman Reinvented", Artist = "DJ Suketu", Genre = "Pop"},
            new Song { SongID = 4, Title = "Baby I like your style ", AlbumName = "Views", Artist = "Drake", Genre = "Afrobeat, Hip-hop/rap"},

        };

        public static List<Song> GetAll()
        {
            return songs;
        }

        public static Song GetSong(int songID)
        {
            return songs.Find(x => x.SongID == songID);
        }

        public static void CreateSong(Song newSong)
        {
            songs.Add(newSong);
           
        }

        public static void updateSong(int songID, Song newSong)
        {
            songs.Remove(songs.Find(x => x.SongID == songID));
            songs.Add(newSong);
        }

        public static void DeleteSong(int songID)
        {
            songs.Remove(songs.Find(x => x.SongID == songID));
        }
    }
}