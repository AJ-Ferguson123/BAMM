using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagTitle { get; set; }

        public virtual int SongId { get; set; }
    }
}
