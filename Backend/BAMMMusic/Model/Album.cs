using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumImage { get; set; }
        public string Label { get; set; }
        public int Date { get; set; }

        public virtual int ArtistId {get;set;}
        public virtual List<Song> Songs { get; set; }
    }
}
