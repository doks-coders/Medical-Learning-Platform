using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services.Interfaces
{
	public interface ICourseService
	{
		IEnumerable<Course> GetAllCourses();

		Course GetCourse(int? id);

		void UpdateCourse(Course course);

		void AddCourse(Course course);

		void DeleteCourse(int id);
	}
}
