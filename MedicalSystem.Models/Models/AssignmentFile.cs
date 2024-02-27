using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Models.Models
{
	public class AssignmentFile
	{
		[Key]
		public int Id { get; set; }
		public string FileUrl { get; set; }

		public int TopicId { get; set; }	
		
		[ForeignKey(nameof(TopicId))]
		public Topic Topic { get; set; }
	}
}
