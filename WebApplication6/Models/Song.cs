using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}