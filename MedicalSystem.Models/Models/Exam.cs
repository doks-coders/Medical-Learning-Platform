using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Models.Models
{
	public class Exam
	{
		[Key]
		public int Id { get; set; }

		public string CourseName { get; set; }

		public string ExamName { get; set; }

		public int Year { get; set; }

		public DateTime DateUploaded { get; set; } = DateTime.Now;

		[ValidateNever]
		public List<ExamFile> ExamFiles { get; set; }
	}
}
