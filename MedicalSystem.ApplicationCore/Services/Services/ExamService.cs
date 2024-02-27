using MedicalSystem.ApplicationCore.Constants;
using MedicalSystem.ApplicationCore.Services.Interfaces;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services.Services
{
	public class ExamService:IExamService
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;
		public ExamService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment) 
		{
			_unitOfWork = unitOfWork;
			_webHostEnvironment = webHostEnvironment;

        }
		public ExamSaveCode AddExam(Exam exam)
		{
			_unitOfWork.Exams.Add(exam);
			_unitOfWork.Save();
			return ExamSaveCode.Success;
		}

		public IEnumerable<Exam> GetExams()
		{
			return _unitOfWork.Exams.GetAll();
		}

		public Exam GetExam(int? id)
		{
			return _unitOfWork.Exams.Get(u => u.Id == id,includeProperties: "ExamFiles");
		}

		public void SaveExam(Exam exam)
		{
			_unitOfWork.Exams.Add(exam);
			_unitOfWork.Save();
		}

		public void UpdateExam(Exam exam)
		{
			_unitOfWork.Exams.Update(exam);
			_unitOfWork.Save();
		}

		public void UploadExamFiles(IList<IFormFile>? examFiles,Exam exam)
		{
			string wwwrootPath = _webHostEnvironment.WebRootPath;
			foreach(FormFile file in examFiles)
			{
				string fileName =  Guid.NewGuid()+Path.GetExtension(file.FileName);
				string filePath = @$"images/past-questions-{exam.Id}";
				string folderPathUrl = @$"{wwwrootPath}/{filePath}";

				if (!Directory.Exists(folderPathUrl))
				{
					Directory.CreateDirectory(folderPathUrl);
				}

				using(var fileStream = new FileStream($@"{folderPathUrl}/{fileName}", FileMode.Create))
				{
					file.CopyTo(fileStream);
				}

				ExamFile examfile = new ExamFile()
				{
					FileUrl = @$"{filePath}/{fileName}"
				};

				if(exam.ExamFiles == null)
				{
					exam.ExamFiles = new List<ExamFile>();
				}

				//_unitOfWork.ExamFiles.Add(examfile);
				exam.ExamFiles.Add(examfile);

			}
			_unitOfWork.Exams.Update(exam);
			_unitOfWork.Save();
        }


		public void DeleteExam(int?id)
		{
			Exam exam =	_unitOfWork.Exams.Get(u => u.Id == id);
			if(exam != null)
			{
				_unitOfWork.Exams.Remove(exam);
			}
			_unitOfWork.Save();
		}
	}
}
