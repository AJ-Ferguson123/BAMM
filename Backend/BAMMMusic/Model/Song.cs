using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        
        public virtual int ArtistId { get; set; }
        public virtual string ArtistName { get; set; }
        public virtual int AlbumId { get; set; }
        public virtual string AlbumTitle { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}
