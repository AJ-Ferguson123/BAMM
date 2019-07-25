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
    public class AlbumsController : ControllerBase
    {
        private MusicContext _context;

        public AlbumsController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/Albums
        [HttpGet]
        public IEnumerable<Album> GetAlbums()
        {
            return _context.Albums.ToList();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public ActionResult<Album> GetAlbumById(int id)
        {
            Album album = _context.Albums.Single(c => c.AlbumId == id);

            return album;
        }

        // PUT: api/Albums/5
        [HttpPut]
        public ActionResult<Artist> Put([FromBody] Album album)
        {
            _context.Albums.Update(album);
            _context.SaveChanges();
            return _context.Artists.Single(a => a.ArtistId == album.ArtistId);
        }

        // POST: api/Albums
        [HttpPost]
        public ActionResult<Artist> Post([FromBody] Album album)
        {           
            _context.Albums.Add(album);
            _context.SaveChanges();
            return _context.Artists.Single(a => a.ArtistId == album.ArtistId);
        }

        //DELETE: api/Albums/5
        [HttpDelete]

        public ActionResult<Artist> Delete([FromBody] Album album)
        {
            var deletedalbum = album.ArtistId;
            _context.Albums.Remove(album);
            _context.SaveChanges();
            return _context.Artists.Single(a => a.ArtistId == deletedalbum);
        }
        //[HttpDelete]
        //public ActionResult<IEnumerable<Album>> Delete([FromBody]Album album)
        //{
        //    _context.Albums.Remove(album);
        //    _context.SaveChanges();
        //    return _context.Albums.ToList();
        //}
    }
}