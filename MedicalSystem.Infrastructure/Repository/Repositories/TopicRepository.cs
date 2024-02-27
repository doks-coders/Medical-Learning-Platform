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
	public class TopicRepository:Repository<Topic>,ITopicRepository
	{
		private readonly ApplicationDbContext _db;
		public TopicRepository(ApplicationDbContext db):base(db)
		{
			_db = db;
		}

		public void Update(Topic topic)
		{
			Topic topicFromDb = _db.Topics.FirstOrDefault(u=>u.Id == topic.Id);
			if (topicFromDb != null)
			{
				topicFromDb.Title = topic.Title;
                topicFromDb.About = topic.About;
                topicFromDb.LectureDate = topic.LectureDate;
                topicFromDb.DateUploaded = topic.DateUploaded;
                topicFromDb.NoteFiles = topic.NoteFiles;
                topicFromDb.AssignmentFiles = topic.AssignmentFiles;
            }
		}
	}
}
