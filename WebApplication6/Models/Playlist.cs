using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Playlist
    {
        public int PlaylistID { get; set; }
        public string Name { get; set; }
        public ICollection<BookPlaylist> BookPlaylists { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}