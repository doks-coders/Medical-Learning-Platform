using MedicalSystem.ApplicationCore.Constants;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services.Interfaces
{
	public interface IExamService
	{
		public ExamSaveCode AddExam(Exam exam);

		IEnumerable<Exam> GetExams();

		Exam GetExam(int? id);

		public void SaveExam(Exam exam);

		public void UpdateExam(Exam exam);

		public void UploadExamFiles(IList<IFormFile>? examFiles, Exam exam);

		public void DeleteExam(int? id);

    }
}
