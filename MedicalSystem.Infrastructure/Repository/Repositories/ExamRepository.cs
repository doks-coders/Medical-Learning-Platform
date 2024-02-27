using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Repositories
{
	public class ExamRepository:Repository<Exam>,IExamRepository
	{
		private readonly ApplicationDbContext _db;
		public ExamRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(Exam exam)
		{
			Exam retrievedExam = _db.Exams.FirstOrDefault(u=>u.Id== exam.Id);
			if (retrievedExam != null)
			{
				retrievedExam.DateUploaded = exam.DateUploaded;
				retrievedExam.ExamFiles = exam.ExamFiles;
				retrievedExam.Year = exam.Year;
				retrievedExam.CourseName = exam.CourseName;
				retrievedExam.ExamName = exam.ExamName;
			}
		}
	}
}
