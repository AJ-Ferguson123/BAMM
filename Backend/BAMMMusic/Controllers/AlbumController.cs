using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAMMMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        // GET: api/Album
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Live Killer", "News Of The World", "Love Symbol", "Sign Of The Times" };
        }

        // GET: api/Album
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Album
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Album
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Album
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }




}
