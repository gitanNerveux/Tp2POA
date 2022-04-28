using System;
using System.ComponentModel.DataAnnotations;

namespace Tp2POA.Models
{
	public abstract class Personne
	{
		public Personne()
		{
		}

		public string Nom { get; set; }

		public string Prenom { get; set; }

		public DateTime DateDeNaissance { get; set; }
		public string Genre { get; set; }
	}
}

