using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BAMMMusic;
using BAMMMusic.Model;

namespace BAMMMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private MusicContext _context;

        public SongsController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/Songs
        [HttpGet]
        public IEnumerable<Song> GetSongs()
        {
            return _context.Songs.ToList();
        }

        // GET: api/Songs/5
        [HttpGet("{id}")]
        public ActionResult<Song> GetSongById(int id)
        {
            Song song = _context.Songs.Single(c => c.SongId == id);                    

            return song;
        }

        // PUT: api/Songs/5
        [HttpPut]
        public ActionResult<IEnumerable<Song>> Put([FromBody]Song song)
        {
            _context.Songs.Update(song);
            _context.SaveChanges();
            return _context.Songs;
        }

        // POST: api/Songs
        [HttpPost]
        public ActionResult<IEnumerable<Song>> Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return _context.Songs.ToList();
        }

        // DELETE: api/Songs/5
        [HttpDelete]
        public ActionResult<IEnumerable<Song>> Delete([FromBody]Song song)
        {
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return _context.Songs.ToList();
        }
    }
}