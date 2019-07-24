using BAMMMusic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAMMMusic.Repositories
{
    public class ArtistRepository: IRepository<Artist>
    { 
        public IEnumerable<Artist> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
