using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAMMMusic.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAMMMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly MusicContext _context;

        public ArtistController(MusicContext context)
        {
            _context = context;
        }
        // GET: api/Artist
        [HttpGet]
        public IEnumerable<Artist> GetArtists()
        {
            return _context.Artists;
        }

        // GET: api/Artist/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Artist
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Artist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
