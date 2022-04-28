using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_Tp2Poa.Controllers
{
    [Route("api/diagnostic")]
    public class DiagnosticController : Controller
    {
        private Tp2POA.Models.Tp2POAContext _context;

        public DiagnosticController()
        {
            _context = new Tp2POA.Models.Tp2POAContext();
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetDiagnostic(int id)
        {
            try
            {
                Tp2POA.Models.Diagnostic diagnostic = _context.Diagnostics.Find(id);
                if (diagnostic != null)
                    return Ok(diagnostic);
                else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDiagnostic(int id)
        {
            try
            {
                Tp2POA.Models.Diagnostic diagnostic = _context.Diagnostics.Find(id);
                if (diagnostic != null)
                {
                    _context.Remove(diagnostic);
                    _context.SaveChanges();
                } else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }
    }
}

