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
                    ArtistImage = "/Images/princeMusician1.jpg/",
                    Hometown = "Minneapolis, Minnesota",
                    Age = 57,
                },
                new Artist
                {
                    ArtistId = 2,
                    ArtistName = "Queen",
                    ArtistImage = "/Images/queen2.jpg/",
                    Hometown = "London",
                    Age = 49,
                });

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
                });

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
                    Title = "And God Created Woman'",
                    Duration = "3:18",
                    ArtistId = 1,
                    AlbumId = 1,
                },
                new Song
                {
                    SongId = 3,
                    Title = "Sign O the Times",
                    Duration = "3:42",
                    ArtistId = 1,
                    AlbumId = 2,
                },
                new Song
                {
                    SongId = 4,
                    Title ="U Got the Look",
                    Duration= "3:58",
                    ArtistId=1,
                    AlbumId=2,
                },
                new Song
                {
                    SongId=5,
                    Title="You're My Best Friend",
                    Duration="2:07",
                    ArtistId=2,
                    AlbumId=3,
                },
                new Song
                {
                    SongId=6,
                    Title="Killer Queen",
                    Duration="1:59",
                    ArtistId=2,
                    AlbumId=3
                },
                new Song
                {
                    SongId=7,
                    Title="We Are the Champions",
                    Duration="3:01",
                    ArtistId=2,
                    AlbumId=4,
                },
                new Song
                {
                    SongId=8,
                    Title="We Will Rock You",
                    Duration="2:02",
                    ArtistId=2,
                    AlbumId=4
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId=1,
                    CommentDetails="I'm a little offended by the title, but man.. is this song GREAT!",
                    SongId=1,
                },
                new Comment
                {
                    CommentId=2,
                    CommentDetails="As a self-described feminist, I love this song!",
                    SongId=2,
                },
                new Comment
                {
                    CommentId=3,
                    CommentDetails="This is such a great party song!",
                    SongId=3,
                },
                new Comment
                {
                    CommentId=4,
                    CommentDetails="I feel like this song has a deeper meaning than I understand... Not a huge fan..",
                    SongId=4,
                },
                new Comment
                {
                    CommentId=5,
                    CommentDetails="My husband and I danced to this for our first dance. Such a beautiful song.",
                    SongId=5,
                },
                new Comment
                {
                    CommentId=6,
                    CommentDetails="I always sing along when this song is on the radio. So catchy!",
                    SongId=6,
                },
                new Comment
                {
                    CommentId=7,
                    CommentDetails="I just won a really intense game of beer pong.... obviously I've had to blast this song for the past 3 days. Classic.",
                    SongId=7,
                },
                new Comment
                {
                    CommentId=8,
                    CommentDetails="You just can't not stomp your foot along with the beat... Such a classic song!",
                    SongId=8
                }
                );
            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    TagId=1,
                    TagTitle="Rock & Roll",
                    SongId=8,
                },
                new Tag
                {
                    TagId=2,
                    TagTitle="Sing-Along",
                    SongId=7,
                },
                new Tag
                {
                    TagId=3,
                    TagTitle="Live Music",
                    SongId=6,
                },
                new Tag
                {
                    TagId=4,
                    TagTitle="cool",
                    SongId=1,
                },
                new Tag
                {
                    TagId=5,
                    TagTitle="groovy",
                    SongId=4,
                },
                new Tag
                {
                    TagId=6,
                    TagTitle="Love Song",
                    SongId=5,
                },
                new Tag
                {
                    TagId=7,
                    TagTitle="Smooth Melody",
                    SongId=2,
                },
                new Tag
                {
                    TagId=8,
                    TagTitle="Statment Song",
                    SongId=3,
                }
                );
        }
    }
}
