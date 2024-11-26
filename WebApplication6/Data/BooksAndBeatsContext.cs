using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class BooksAndBeatsContext
    {
        public BooksAndBeatsContext(DbContextOptions<BooksAndBeatsContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<BookPlaylist> BookPlaylists { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookPlaylist>()
                .HasKey(bp => new { bp.BookID, bp.PlaylistID });

            modelBuilder.Entity<PlaylistSong>()
                .HasKey(ps => new { ps.PlaylistID, ps.SongID });
        }
    }
}