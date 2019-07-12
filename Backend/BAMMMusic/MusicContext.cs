using BAMMMusic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BAMMmusic;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    ArtistName = "Prince",
                    ArtistImage = "princeMusician1.jpg",
                    Hometown = "Minneapolis, Minnesota",
                    Age = 57,

                },
                new Artist
                {
                    ArtistId = 2,
                    ArtistName = "Queen",
                    ArtistImage = "queen2.jpg",
                    Hometown = "London",
                    Age = 49,

                }
                );
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    AlbumTitle = "Love Symbol",
                    AlbumImage = "loveSymbol.jpg",
                    Label = "Rhino/Warner Brothers",
                    ArtistId = 1,
                    Date = 1992
                },
                new Album
                {
                    AlbumId = 2,
                    AlbumTitle = "Sign Of the Times",
                    AlbumImage = "princeSignOTimes.png",
                    Label = "Paisley Park",
                    ArtistId = 1,
                    Date = 1987,

                },
                new Album
                {
                    AlbumId = 3,
                    AlbumTitle = "Live Killers",
                    AlbumImage = "QueenKillers.png",
                    Label = "EMI-Elektra",
                    ArtistId = 2,
                    Date = 1979
                },
                new Album
                {
                    AlbumId = 4,
                    AlbumTitle = "News Of The World",
                    AlbumImage = "NewsWorld",
                    Label = "EMI-Elektra",
                    ArtistId = 2,
                    Date = 1977
                
                }

                );
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Title = "Sexy MF",
                    Duration = "3:31",
                    ArtistId = 1,
                    AlbumId = 1,


                },
                new Song
                {
                    SongId = 2,
                    Title = "Strollin'",
                    Duration = "3:45",
                    ArtistId = 1,
                    AlbumId = 1,


                },
                new Song
                {
                    SongId = 3,
                    Title = "Sign O the Times",
                    Duration = "4:57",
                    ArtistId = 1,
                    AlbumId = 2,
                }

                );

        }
    }
}
