using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class PlaylistSong
    {
        public int PlaylistID { get; set; }
        public int SongID { get; set; }
        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}