using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class BookPlaylist
    {
        public int BookID { get; set; }
        public int PlaylistID { get; set; }
        public Book Book { get; set; }
        public Playlist Playlist { get; set; }
    }
}