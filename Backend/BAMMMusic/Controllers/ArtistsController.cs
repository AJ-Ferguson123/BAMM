using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BAMMMusic;
using BAMMMusic.Model;
using Microsoft.AspNetCore.Cors;

namespace BAMMMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private MusicContext _context;


        public ArtistsController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/Artists
        [HttpGet]
        public IEnumerable<Artist> GetArtists()
        {
            return _context.Artists.ToList();

        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public ActionResult<Artist> GetArtistById(int id)
        {
            Artist artist = _context.Artists.Single(c => c.ArtistId == id);

            //if (artist == null)
            //{
            //    return NotFound();
            //}

            return artist;
            
        }

       

        // POST: api/Artists
        [HttpPost]
        public ActionResult<IEnumerable<Artist>> Post([FromBody] Artist artist)
        {
            //all.Add(todo);
            //return all;

            _context.Artists.Add(artist);
            _context.SaveChanges();
            return _context.Artists.ToList();
        }

        // DELETE: api/Artists/5
        [HttpDelete]
        public ActionResult<IEnumerable<Artist>> Delete([FromBody]Artist artist)
        {
            _context.Artists.Remove(artist);
            _context.SaveChanges();
            return _context.Artists.ToList();
        }

        [HttpPut]
        public ActionResult<IEnumerable<Artist>> Put([FromBody]Artist artist)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
            return _context.Artists;
        }
    }
}