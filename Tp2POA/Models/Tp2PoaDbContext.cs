using System;
using Microsoft.EntityFrameworkCore;

namespace Tp2POA.Models
{
	public class Tp2PoaDbContext : DbContext
	{
		public DbSet<Models.Patient> Patients { get; set; }

		public DbSet<Models.Medecin> Medecins { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
			string ConnectionString = "server=localhost;port=3306;database=Tp2POA;user=root;password=wazaza19;";
			dbContextOptionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Models.Patient>().HasData(
				new Models.Patient() { Nom = "Baudy", Prenom = "Jose" },
				new Models.Patient() { Nom = "Rayas", Prenom = "Wahid" }
			);
        }
	}
}

