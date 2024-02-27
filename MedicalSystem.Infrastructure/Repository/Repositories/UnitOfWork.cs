using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		internal ApplicationDbContext _db;
		
		public IExamRepository Exams { get; }
		public IExamFileRepository ExamFiles { get; }

		public ICourseRepository Courses { get; }

		public ITopicRepository Topics { get;  }

		public UnitOfWork(ApplicationDbContext db) 
		{
			_db = db;
			Exams = new ExamRepository(_db);
			ExamFiles = new ExamFileRepository(_db);
			Courses = new CourseRepository(_db);
			Topics = new TopicRepository(_db);
			
		}


		public void Save() 
		{
			_db.SaveChanges();
		}
		
	}
}
