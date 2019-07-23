﻿// <auto-generated />
using BAMMMusic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BAMMMusic.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20190719153441_artistController")]
    partial class artistController
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAMMMusic.Model.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumImage");

                    b.Property<string>("AlbumTitle");

                    b.Property<int>("ArtistId");

                    b.Property<int>("Date");

                    b.Property<string>("Label");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, AlbumImage = "loveSymbol.jpg", AlbumTitle = "Love Symbol", ArtistId = 1, Date = 1992, Label = "Rhino/Warner Brothers" },
                        new { AlbumId = 2, AlbumImage = "princeSignOTimes.png", AlbumTitle = "Sign Of the Times", ArtistId = 1, Date = 1987, Label = "Paisley Park" },
                        new { AlbumId = 3, AlbumImage = "QueenKillers.png", AlbumTitle = "Live Killers", ArtistId = 2, Date = 1979, Label = "EMI-Elektra" },
                        new { AlbumId = 4, AlbumImage = "NewsWorld", AlbumTitle = "News Of The World", ArtistId = 2, Date = 1977, Label = "EMI-Elektra" }
                    );
                });

            modelBuilder.Entity("BAMMMusic.Model.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("ArtistImage");

                    b.Property<string>("ArtistName");

                    b.Property<string>("Hometown");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new { ArtistId = 1, Age = 57, ArtistImage = "/Images/princeMusician1.jpg/", ArtistName = "Prince", Hometown = "Minneapolis, Minnesota" },
                        new { ArtistId = 2, Age = 49, ArtistImage = "/Images/queen2.jpg/", ArtistName = "Queen", Hometown = "London" }
                    );
                });

            modelBuilder.Entity("BAMMMusic.Model.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentDetails");

                    b.Property<int>("SongId");

                    b.HasKey("CommentId");

                    b.HasIndex("SongId");

                    b.ToTable("Comments");

                    b.HasData(
                        new { CommentId = 1, CommentDetails = "I'm a little offended by the title, but man.. is this song GREAT!", SongId = 1 },
                        new { CommentId = 2, CommentDetails = "As a self-described feminist, I love this song!", SongId = 2 },
                        new { CommentId = 3, CommentDetails = "This is such a great party song!", SongId = 3 },
                        new { CommentId = 4, CommentDetails = "I feel like this song has a deeper meaning than I understand... Not a huge fan..", SongId = 4 },
                        new { CommentId = 5, CommentDetails = "My husband and I danced to this for our first dance. Such a beautiful song.", SongId = 5 },
                        new { CommentId = 6, CommentDetails = "I always sing along when this song is on the radio. So catchy!", SongId = 6 },
                        new { CommentId = 7, CommentDetails = "I just won a really intense game of beer pong.... obviously I've had to blast this song for the past 3 days. Classic.", SongId = 7 },
                        new { CommentId = 8, CommentDetails = "You just can't not stomp your foot along with the beat... Such a classic song!", SongId = 8 }
                    );
                });

            modelBuilder.Entity("BAMMMusic.Model.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<int>("ArtistId");

                    b.Property<string>("Duration");

                    b.Property<string>("Title");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, ArtistId = 1, Duration = "3:31", Title = "Sexy MF" },
                        new { SongId = 2, AlbumId = 1, ArtistId = 1, Duration = "3:18", Title = "And God Created Woman'" },
                        new { SongId = 3, AlbumId = 2, ArtistId = 1, Duration = "3:42", Title = "Sign O the Times" },
                        new { SongId = 4, AlbumId = 2, ArtistId = 1, Duration = "3:58", Title = "U Got the Look" },
                        new { SongId = 5, AlbumId = 3, ArtistId = 2, Duration = "2:07", Title = "You're My Best Friend" },
                        new { SongId = 6, AlbumId = 3, ArtistId = 2, Duration = "1:59", Title = "Killer Queen" },
                        new { SongId = 7, AlbumId = 4, ArtistId = 2, Duration = "3:01", Title = "We Are the Champions" },
                        new { SongId = 8, AlbumId = 4, ArtistId = 2, Duration = "2:02", Title = "We Will Rock You" }
                    );
                });

            modelBuilder.Entity("BAMMMusic.Model.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SongId");

                    b.Property<string>("TagTitle");

                    b.HasKey("TagId");

                    b.HasIndex("SongId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { TagId = 1, SongId = 8, TagTitle = "Rock & Roll" },
                        new { TagId = 2, SongId = 7, TagTitle = "Sing-Along" },
                        new { TagId = 3, SongId = 6, TagTitle = "Live Music" },
                        new { TagId = 4, SongId = 1, TagTitle = "cool" },
                        new { TagId = 5, SongId = 4, TagTitle = "groovy" },
                        new { TagId = 6, SongId = 5, TagTitle = "Love Song" },
                        new { TagId = 7, SongId = 2, TagTitle = "Smooth Melody" },
                        new { TagId = 8, SongId = 3, TagTitle = "Statment Song" }
                    );
                });

            modelBuilder.Entity("BAMMMusic.Model.Album", b =>
                {
                    b.HasOne("BAMMMusic.Model.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BAMMMusic.Model.Comment", b =>
                {
                    b.HasOne("BAMMMusic.Model.Song")
                        .WithMany("Comments")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BAMMMusic.Model.Song", b =>
                {
                    b.HasOne("BAMMMusic.Model.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BAMMMusic.Model.Tag", b =>
                {
                    b.HasOne("BAMMMusic.Model.Song", "Song")
                        .WithMany("Tags")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
