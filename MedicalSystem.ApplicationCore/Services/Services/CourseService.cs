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
	public class CourseService : ICourseService
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly IUnitOfWork _unitOfWork;
		public CourseService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment) 
		{
			_webHostEnvironment = webHostEnvironment;
			_unitOfWork = unitOfWork;
		}
		public void DeleteCourse(int id)
		{
			Course course = _unitOfWork.Courses.Get(u => u.Id == id);
			_unitOfWork.Courses.Remove(course);
			_unitOfWork.Save();
		}

		public IEnumerable<Course> GetAllCourses()
		{
			return _unitOfWork.Courses.GetAll();
		}

		public Course GetCourse(int? id)
		{
			return _unitOfWork.Courses.Get(u => u.Id == id);
		}

		public void AddCourse(Course course)
		{
			_unitOfWork.Courses.Add(course);
			_unitOfWork.Save();
		}
		public void UpdateCourse(Course course)
		{
			_unitOfWork.Courses.Update(course);
			_unitOfWork.Save();
		}

		
	}
}
