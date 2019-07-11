using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentDetails { get; set; }

        public virtual int SongId { get; set; }
    }
}
