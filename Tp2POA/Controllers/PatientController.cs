using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tp2POA.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Patient> patients = new List<Models.Patient>()
            {
                new Models.Patient(){ Nom = "Baudy", Prenom="Jose"},
                new Models.Patient(){ Nom = "Siakam", Prenom="Pascal"}
            };

            ViewBag.Title = "salut frro!";
            return View(patients);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Patient patient)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result", patient);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Result(Models.Patient patient)
        {
            return View(patient);
        }
    }
}

