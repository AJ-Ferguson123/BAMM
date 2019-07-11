using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Label { get; set; }
        public int Date { get; set; }

        public virtual int ArtistId {get;set;}
        public virtual List<Song> Songs { get; set; }
    }
}
