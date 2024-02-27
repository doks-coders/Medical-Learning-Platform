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
	public class CourseRepository:Repository<Course>,ICourseRepository
	{
		public CourseRepository(ApplicationDbContext db):base(db)
		{

		}

		public void Update(Course course)
		{

		}
	}
}
