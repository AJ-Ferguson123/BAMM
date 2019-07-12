using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistImage { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
