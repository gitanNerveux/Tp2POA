using System;
using System.ComponentModel.DataAnnotations;


namespace Tp2POA.Models
{
	public class Medecin
	{
		public Medecin()
		{
			Patients = new List<Patient>();
		}

		public int MedecinId { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Prenom { get; set; }

		public DateTime DateDeNaissance { get; set; }
		public string Genre { get; set; }
		public DateTime DateEntreeFonction { get; set; }
		public string Mail { get; set; }
		public string Ville { get; set; }
		public string Mdp { get; set; }

		public ICollection<Patient> Patients { get; set; }
	}
}

