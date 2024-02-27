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
	public class TopicService : ITopicService
	{
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly IUnitOfWork _unitOfWork;
		public TopicService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment) 
		{
			_webHostEnvironment = webHostEnvironment;
			_unitOfWork = unitOfWork;
		}


		
		public IEnumerable<Topic> GetAllTopics()
		{
			return _unitOfWork.Topics.GetAll(includeProperties:"Course");
		}
        public IEnumerable<Topic> GetAllCourseTopics(int courseId)
        {
            return _unitOfWork.Topics.GetAll(includeProperties: "Course",query:u=>u.Course.Id==courseId);
        }


        public Topic GetTopic(int? id)
		{
			return _unitOfWork.Topics.Get(u => u.Id == id, includeProperties: "Course,NoteFiles,AssignmentFiles");
		}

		
		public void UpdateTopic(Topic topic)
		{
			_unitOfWork.Topics.Update(topic);
			_unitOfWork.Save();
		}


		public void AddTopic(Topic topic)
		{
			_unitOfWork.Topics.Add(topic);
			_unitOfWork.Save();
		}

		

        public void UploadAssignmentFiles(IList<IFormFile>? assignmentFiles, Topic topic)
		{
			string wwwrootPath = _webHostEnvironment.WebRootPath;
			foreach (FormFile file in assignmentFiles)
			{
				string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
				string filePath = @$"images/assignment-{topic.Id}";
				string folderPathUrl = @$"{wwwrootPath}/{filePath}";

				CopyFilesToDirectory(folderPathUrl, fileName, file);

                AssignmentFile assignmentFile = new AssignmentFile()
				{
					FileUrl = @$"{filePath}/{fileName}"
				};

                if (topic.AssignmentFiles == null)
                {
                    topic.AssignmentFiles = new List<AssignmentFile>();
                }
                topic.AssignmentFiles.Add(assignmentFile);

            }
			_unitOfWork.Topics.Update(topic);
			_unitOfWork.Save();

		}

        public void UploadNoteFiles(IList<IFormFile>? noteFiles, Topic topic)
        {
            string wwwrootPath = _webHostEnvironment.WebRootPath;
            foreach (FormFile file in noteFiles)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                string filePath = @$"images/notes-{topic.Id}";
                string folderPathUrl = @$"{wwwrootPath}/{filePath}";

                CopyFilesToDirectory(folderPathUrl, fileName, file);

                NoteFile noteFile = new NoteFile()
                {
                    FileUrl = @$"{filePath}/{fileName}"
                };

                if (topic.NoteFiles == null)
                {
                    topic.NoteFiles = new List<NoteFile>();
                }
                topic.NoteFiles.Add(noteFile);

            }
            _unitOfWork.Topics.Update(topic);
            _unitOfWork.Save();

        }


        public void DeleteTopic(int id)
		{
			Topic topic = _unitOfWork.Topics.Get(u => u.Id == id);
			_unitOfWork.Topics.Remove(topic);
			_unitOfWork.Save();
		}


        static void CopyFilesToDirectory(string folderPathUrl, string fileName, FormFile file)
        {
            if (!Directory.Exists(folderPathUrl))
            {
                Directory.CreateDirectory(folderPathUrl);
            }
            using (var fileStream = new FileStream($@"{folderPathUrl}/{fileName}", FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
        }

    }
}
