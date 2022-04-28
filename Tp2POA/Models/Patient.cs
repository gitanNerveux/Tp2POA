using System;
using System.ComponentModel.DataAnnotations;

namespace Tp2POA.Models
{
	public class Patient
	{
		public Patient()
		{
			Diagnostics = new List<Diagnostic>();
		}

		public int PatientId { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Prenom { get; set; }

		public DateTime DateDeNaissance { get; set; }
		public string Genre { get; set; }
		public bool Diagnostic { get; set; }
		public int MedecinId { get; set; }
		public Medecin Medecin { get; set; }

		public ICollection<Diagnostic> Diagnostics { get; set; }
	}
}

