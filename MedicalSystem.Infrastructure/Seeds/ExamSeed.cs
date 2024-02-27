using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Seeds
{
	public class ExamSeed
	{
		public List<Exam> GetExamSeedData()
		{
			return new List<Exam>
			{
			new Exam
		{
			Id = 1,
			CourseName = "Anatomy",
			ExamName = "MED Anatomy 101",
			Year = 2024,
			DateUploaded = DateTime.Now
		},
		new Exam
		{
			Id = 2,
			CourseName = "Biochemistry",
			ExamName = "Med Biochem Exam",
			Year = 2024,
			DateUploaded = DateTime.Now
		},
		new Exam
		{
			Id = 3,
			CourseName = "Pathology",
			ExamName = "Pathology Board Exam",
			Year = 2024,
			DateUploaded = DateTime.Now
		},
		new Exam
		{
			Id = 4,
			CourseName = "Pharmacology",
			ExamName = "Pharmaceutical Licensing Exam",
			Year = 2024,
			DateUploaded = DateTime.Now
		},
		new Exam
		{
			Id = 5,
			CourseName = "Clinical Skills",
			ExamName = "Clinical Skills Assessment",
			Year = 2024,
			DateUploaded = DateTime.Now
		}
			};
		}
	}
}
