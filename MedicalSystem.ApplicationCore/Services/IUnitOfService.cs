using MedicalSystem.ApplicationCore.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services
{
	public interface IUnitOfService
	{
		public IExamService examService { get; }
		public ITopicService topicService { get; }
		public ICourseService courseService { get; }
        public IWebHostEnvironment webHostEnvironment { get; }

    }
}
