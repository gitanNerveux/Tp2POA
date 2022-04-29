using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tp2POA;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_Tp2Poa.Controllers
{
    [Produces("application/json")]
    [Route("api/patients")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private Tp2POA.Models.Tp2POAContext _context;

        public PatientController()
        {
            _context = new Tp2POA.Models.Tp2POAContext();
        }

        [HttpGet]
        public IActionResult GetPatients(int MedecinId)
        {
            try
            {
                Tp2POA.Models.Medecin medecin = _context.Medecins.Find(MedecinId);
                if (medecin != null)
                    return Ok(medecin.Patients);
                else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        
        // GET: api/patients/id/diagnostics
        [HttpGet("{id}/diagnostics")]
        public IActionResult GetPatientDiagnostics(int patientId)
        {
            try
            {
                Tp2POA.Models.Patient patient = _context.Patients.Find(patientId);
                if (patient != null)
                    return Ok(patient.Diagnostic);
                else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
            
        }

        // GET api/patients/id
        [HttpGet("{id}")]
        public IActionResult GetPatient(int id)
        {
            try
            {
                Tp2POA.Models.Patient patient = _context.Patients.Find(id);
                if (patient != null)
                    return Ok(patient);
                else
                    return StatusCode((int)HttpStatusCode.NotFound);
                
            } catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        // POST api/values
        [HttpPost(Name ="{id}/diagnose")]
        public IActionResult PostDiagnose([FromBody] Tp2POA.Models.Patient patient)
        {
           try
            {
                _context.Patients.Add(patient);
                _context.SaveChanges();
                return Ok(patient);
            } catch(Exception) { }

            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Tp2POA.Models.Patient patient = _context.Patients.Find(id);
                if (patient != null)
                {
                    _context.Remove(patient);
                    _context.SaveChanges();
                }
                else
                    return StatusCode((int)HttpStatusCode.NotFound);

            }
            catch (Exception) { }

            return StatusCode((int)HttpStatusCode.BadRequest);
        }
    }
}

