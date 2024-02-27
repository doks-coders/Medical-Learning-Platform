using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Interfaces
{
	public interface IUnitOfWork
	{
		IExamRepository Exams {  get; }
		IExamFileRepository ExamFiles { get; }
		ICourseRepository Courses { get; }
		ITopicRepository Topics { get; }

		void Save();
	}
}
