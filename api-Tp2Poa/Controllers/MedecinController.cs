using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_Tp2Poa.Controllers
{
    [Route("api")]
    public class MedecinController : Controller
    {
        private Tp2POA.Models.Tp2POAContext _context;

        public MedecinController()
        {
            _context = new Tp2POA.Models.Tp2POAContext();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("info")]
        public IActionResult GetMedecin(int id)
        {
            try
            {
                Tp2POA.Models.Medecin medecin = _context.Medecins.Find(id);
                if (medecin != null)
                    return Ok(medecin);
                else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

