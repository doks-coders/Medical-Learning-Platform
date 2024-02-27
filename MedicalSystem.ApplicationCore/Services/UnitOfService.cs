using MedicalSystem.ApplicationCore.Services.Interfaces;
using MedicalSystem.ApplicationCore.Services.Services;
using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Infrastructure.Repository.Repositories;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services
{
	public class UnitOfService : IUnitOfService
	{
		public IExamService examService {  get;  }
		public ITopicService topicService { get; }
		public ICourseService courseService { get; }
		public IWebHostEnvironment webHostEnvironment { get; }

		public UnitOfService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
			examService = new ExamService(unitOfWork, webHostEnvironment);
			topicService = new TopicService(unitOfWork, webHostEnvironment);
			courseService = new CourseService(unitOfWork, webHostEnvironment);
		}

	}
}
