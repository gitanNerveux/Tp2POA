using System;
using System.ComponentModel.DataAnnotations;

namespace Tp2POA.Models
{
	public class Patient
	{
		public Patient()
		{
			
		}

		public int PatientId { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Prenom { get; set; }

		public DateTime DateDeNaissance { get; set; }
		public string Genre { get; set; }
		public bool Diagnostic { get; set; }
		public bool Singe { get; set; }
	}
}

