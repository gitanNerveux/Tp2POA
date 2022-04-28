using System;
using System.ComponentModel.DataAnnotations;

namespace Tp2POA.Models
{
	public class Patient
	{
		public Patient()
		{
			
		}

		[Required(ErrorMessage = "Champs requis !")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Prenom { get; set; }

		public DateTime DateDeNaissance;
		public string Genre;
		public bool Diagnostic;
	}
}

