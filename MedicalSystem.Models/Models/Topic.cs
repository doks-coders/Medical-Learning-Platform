using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Models.Models
{
	public class Topic
	{
		[Key]
		public int Id { get; set; }
		
		public string Title { get; set; }

		public string About { get; set; }

		public DateTime LectureDate { get; set; }

		public DateTime DateUploaded { get; set; } = DateTime.Now;

		public int CourseId {get; set; }

		[ForeignKey(nameof(CourseId))]
		public Course Course { get; set; }

		[ValidateNever]
		public List<NoteFile> NoteFiles { get; set; }

		[ValidateNever]
		public List<AssignmentFile> AssignmentFiles { get; set; }



	}
}
