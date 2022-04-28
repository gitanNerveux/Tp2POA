using System;
using Microsoft.EntityFrameworkCore;

namespace Tp2POA.Models
{
	public class Tp2POAContext : DbContext
	{
		public DbSet<Patient> Patients { get; set; }

		public DbSet<Medecin> Medecins { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
			string connexionString = "" +
				"server=localhost;" +
				"port=3306;" +
				"database=diagnosticDB;" +
				"user=root;" +
				"password=wazaza19;";
			dbContextOptionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));
        }

		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			DateTime date = new DateTime(2008, 6, 1, 7, 47, 0);
			modelBuilder.Entity<Models.Patient>().HasData(
				new Models.Patient() { Nom = "Baudy", Prenom = "Jose", PatientId=1, Genre="GorilleTitanesque", DateDeNaissance=date,Diagnostic=true},
				new Models.Patient() { Nom = "Rayas", Prenom = "Wahid", PatientId=2,Genre = "SuperHumain", DateDeNaissance = date, Diagnostic = false }
			);
        }*/
	}
}	

