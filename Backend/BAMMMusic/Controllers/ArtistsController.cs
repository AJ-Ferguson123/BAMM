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

        // PUT: api/Artists/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutArtist([FromRoute] int id, [FromBody] Artist artist)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != artist.ArtistId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(artist).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ArtistExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

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
    }
}