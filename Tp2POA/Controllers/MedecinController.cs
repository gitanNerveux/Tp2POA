using System;
using Microsoft.AspNetCore.Mvc;

namespace Tp2POA.Controllers
{
	public class MedecinController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.Title = "Connection";
			return View();
		}


		[HttpPost]
		public IActionResult AddMedecin(Models.Medecin medecin)
		{
			if (ModelState.IsValid)
			{
				Tp2POA.Models.Tp2POAContext tp2POAContext = new Tp2POA.Models.Tp2POAContext();
				tp2POAContext.Medecins.Add(medecin);
				tp2POAContext.SaveChanges();
				return RedirectToAction("Connexion", medecin);
			}
			return View();
		}

		[HttpGet]
		public IActionResult Connexion(Models.Medecin medecin)
		{
			return View(medecin);
		}


		[HttpGet]
		static void ShowMedecin(int medecinId)
		{
			Tp2POA.Models.Tp2POAContext tp2POAContext = new Tp2POA.Models.Tp2POAContext();
			Models.Medecin medecin = tp2POAContext.Medecins.Find(medecinId);
		}



	}
}