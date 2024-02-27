using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Seeds
{
	public class CourseSeed
	{
		public List<Course> GetCourseSeedData()
		{
			return new List<Course>
			{
				new Course
				{
					Id = 1,
					Name = "Anatomy",
					Description = "Study of the structure and organization of the body and its parts, including organs and tissues."

				
				},
				new Course
				{
					Id = 2,
					Name = "Biochemistry",
					Description = "Exploration of the chemical processes and substances that occur within living organisms."
				},
				new Course
				{
					Id = 3,
					Name = "Pathology",
					Description = "Investigation of the nature and causes of diseases, including the examination of tissues, organs, and bodily fluids."
				},
				new Course
				{
					Id = 4,
					Name = "Pharmacology",
					Description = "Study of drugs and their interactions with living organisms, including their mechanisms of action and therapeutic uses."
				},
				new Course
				{
					Id = 5,
					Name = "Clinical Skills",
					Description = "Development of practical abilities and techniques essential for healthcare professionals, including patient examination and communication."
				}


			};
		}
	}
}
