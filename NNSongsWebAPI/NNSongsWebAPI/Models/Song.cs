using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NNSongsWebAPI.Models
{
    public class Song
    {
        private int songID;
        private string title;
        private string albumName;
        private string artist;
        private string genre;

        public Song()
        { }

        public Song(int songID, string title, string albumName, string artist, string genre)
        {
            this.songID = songID;
            this.title = title;
            this.albumName = albumName;
            this.artist = artist;
            this.genre = genre;

        }

        public int SongID
        {
            get { return songID; }
            set { songID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

    }
}