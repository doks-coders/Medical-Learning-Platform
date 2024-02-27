using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.ApplicationCore.Services.Interfaces
{
	public interface ITopicService
	{
		IEnumerable<Topic> GetAllTopics();
		IEnumerable<Topic> GetAllCourseTopics(int courseId);


        Topic GetTopic(int? id);

		void UpdateTopic(Topic topic);

		void AddTopic(Topic topic);

		void UploadAssignmentFiles(IList<IFormFile>? assignmentFiles, Topic topic);

        void UploadNoteFiles(IList<IFormFile>? notefiles, Topic topic);
		
        void DeleteTopic(int id);

		
	}
}
