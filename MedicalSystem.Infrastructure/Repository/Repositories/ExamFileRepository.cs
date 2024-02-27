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
	public class ExamFileRepository : Repository<ExamFile>, IExamFileRepository
	{
		private readonly ApplicationDbContext _db;
		public ExamFileRepository(ApplicationDbContext db):base(db)
		{
			_db = db;
		}
		public void Update(ExamFile examFile)
		{
			
		}
	}
}
