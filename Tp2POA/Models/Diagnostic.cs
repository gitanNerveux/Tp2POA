using System;
namespace Tp2POA.Models
{
	public class Diagnostic
	{
		public Diagnostic()
		{

		}
		public int DiagnosticId { get; set; }
		public int PatientId { get; set; }
		public Patient Patient { get; set; }
	}
}

