using BAMMMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Repositories
{
    public class AlbumRepository : IRepository<Album>
    {
        public IEnumerable<Album> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
