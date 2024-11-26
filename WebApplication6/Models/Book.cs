using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public int PubYear { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public ICollection<BookPlaylist> BookPlaylists { get; set; }
    }
}
    }
}