using System;
using System.ComponentModel.DataAnnotations;


namespace Tp2POA.Models
{
	public class Medecin
	{
		public Medecin()
		{

		}
		[Required(ErrorMessage = "Champs requis !")]
		public string Nom { get; set; }

		[Required(ErrorMessage = "Champs requis !")]
		public string Prenom { get; set; }

		public DateTime DateDeNaissance;
		public string Genre;
		public DateTime DateEntreeFonction;
		public string Mail;
		public string Ville;
		public string Mdp;
	}
}

