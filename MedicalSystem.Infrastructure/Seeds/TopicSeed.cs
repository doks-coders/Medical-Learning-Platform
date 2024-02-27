using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Seeds
{
	public class TopicSeed
	{
		public List<Topic> GetSeedData()
		{
			List<Topic> topics = anatomyTopics();
			topics.AddRange(biochemistryTopics());
			topics.AddRange(pathologyTopics());
			topics.AddRange(pharmacologyTopics());
			topics.AddRange(clinicalSkillsTopics());

			int i = 0; //!Hack to insert Id  :: Will do that later
			foreach(var topic in topics)
			{
					i++;
					topic.Id = i;
			}
			return topics;
		}
		private List<Topic> anatomyTopics() => new List<Topic>
{
	new Topic
	{
		Title = "Introduction to Human Anatomy",
		About = "An overview of the basic principles and structures of the human body.",
		LectureDate = DateTime.Now.AddDays(1),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Skeletal System",
		About = "In-depth study of the human skeletal system and its functions.",
		LectureDate = DateTime.Now.AddDays(2),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Muscular System",
		About = "Understanding the muscles and their role in movement.",
		LectureDate = DateTime.Now.AddDays(3),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Circulatory System",
		About = "Exploring the anatomy of the heart and blood vessels.",
		LectureDate = DateTime.Now.AddDays(4),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Respiratory System",
		About = "Study of the lungs and the process of breathing.",
		LectureDate = DateTime.Now.AddDays(5),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Digestive System",
		About = "Anatomy of the gastrointestinal tract and digestion.",
		LectureDate = DateTime.Now.AddDays(6),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Nervous System",
		About = "Understanding the structure and function of the nervous system.",
		LectureDate = DateTime.Now.AddDays(7),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Endocrine System",
		About = "Study of glands and hormones regulating body functions.",
		LectureDate = DateTime.Now.AddDays(8),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Urinary System",
		About = "Exploration of the anatomy and function of the kidneys and urinary tract.",
		LectureDate = DateTime.Now.AddDays(9),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Reproductive System",
		About = "Study of the male and female reproductive organs and their functions.",
		LectureDate = DateTime.Now.AddDays(10),
		CourseId = 1,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    }
};

		private List<Topic> biochemistryTopics() => new List<Topic>
{
	new Topic
	{
		Title = "Introduction to Biochemical Processes",
		About = "An overview of fundamental biochemical processes in living organisms.",
		LectureDate = DateTime.Now.AddDays(1),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Enzyme Kinetics and Catalysis",
		About = "Study of enzyme-catalyzed reactions and their kinetics.",
		LectureDate = DateTime.Now.AddDays(2),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Metabolism: An Overview",
		About = "Understanding the general principles of cellular metabolism.",
		LectureDate = DateTime.Now.AddDays(3),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Biochemical Signaling Pathways",
		About = "Exploration of cell communication through biochemical signaling.",
		LectureDate = DateTime.Now.AddDays(4),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Protein Structure and Function",
		About = "In-depth study of the structure and function of proteins.",
		LectureDate = DateTime.Now.AddDays(5),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Nucleic Acids and Genetic Information",
		About = "Understanding the role of nucleic acids in storing and transmitting genetic information.",
		LectureDate = DateTime.Now.AddDays(6),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Carbohydrate Metabolism",
		About = "Study of the metabolic pathways involving carbohydrates.",
		LectureDate = DateTime.Now.AddDays(7),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Lipid Metabolism",
		About = "Exploration of the metabolism of lipids and lipid-derived molecules.",
		LectureDate = DateTime.Now.AddDays(8),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Biochemical Techniques",
		About = "Introduction to experimental techniques in biochemistry.",
		LectureDate = DateTime.Now.AddDays(9),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Clinical Biochemistry",
		About = "Application of biochemistry in clinical settings and diagnostics.",
		LectureDate = DateTime.Now.AddDays(10),
		CourseId = 2,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    }
};

		private List<Topic> pathologyTopics() => new List<Topic>
{
	new Topic
	{
		Title = "Introduction to Medical Pathology",
		About = "An overview of the basic principles and mechanisms of diseases.",
		LectureDate = DateTime.Now.AddDays(1),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Cellular Pathology",
		About = "Study of abnormalities at the cellular level in various diseases.",
		LectureDate = DateTime.Now.AddDays(2),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Inflammation and Repair",
		About = "Understanding the processes of inflammation and tissue repair.",
		LectureDate = DateTime.Now.AddDays(3),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Neoplasia",
		About = "Study of abnormal growths and tumors in various tissues.",
		LectureDate = DateTime.Now.AddDays(4),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Hematologic Pathology",
		About = "Exploration of diseases affecting the blood and blood-forming tissues.",
		LectureDate = DateTime.Now.AddDays(5),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Cardiovascular Pathology",
		About = "Study of diseases affecting the heart and blood vessels.",
		LectureDate = DateTime.Now.AddDays(6),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Respiratory Pathology",
		About = "Exploration of diseases affecting the respiratory system.",
		LectureDate = DateTime.Now.AddDays(7),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Gastrointestinal Pathology",
		About = "Study of diseases affecting the digestive system.",
		LectureDate = DateTime.Now.AddDays(8),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Renal Pathology",
		About = "Understanding diseases affecting the kidneys and urinary tract.",
		LectureDate = DateTime.Now.AddDays(9),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Endocrine Pathology",
		About = "Study of diseases affecting endocrine glands and hormones.",
		LectureDate = DateTime.Now.AddDays(10),
		CourseId = 3,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    }
};

		private List<Topic> pharmacologyTopics() => new List<Topic>
{
	new Topic
	{
		Title = "Introduction to Pharmacology",
		About = "Overview of the study of drugs and their effects on the body.",
		LectureDate = DateTime.Now.AddDays(1),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Pharmacokinetics",
		About = "Study of drug absorption, distribution, metabolism, and excretion.",
		LectureDate = DateTime.Now.AddDays(2),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Pharmacodynamics",
		About = "Understanding the interactions between drugs and their targets in the body.",
		LectureDate = DateTime.Now.AddDays(3),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Drug Classes and Categories",
		About = "Exploration of different classes and categories of drugs.",
		LectureDate = DateTime.Now.AddDays(4),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Adverse Drug Reactions",
		About = "Study of unwanted effects and reactions to drugs.",
		LectureDate = DateTime.Now.AddDays(5),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Antimicrobial Pharmacology",
		About = "In-depth study of drugs targeting bacteria, viruses, and fungi.",
		LectureDate = DateTime.Now.AddDays(6),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Neuropharmacology",
		About = "Exploration of drugs affecting the nervous system.",
		LectureDate = DateTime.Now.AddDays(7),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Cardiovascular Pharmacology",
		About = "Study of drugs affecting the cardiovascular system.",
		LectureDate = DateTime.Now.AddDays(8),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Pain Management",
		About = "Understanding drugs used in the management of pain.",
		LectureDate = DateTime.Now.AddDays(9),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Pharmacotherapy of Common Diseases",
		About = "Application of pharmacological principles in the treatment of common diseases.",
		LectureDate = DateTime.Now.AddDays(10),
		CourseId = 4,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    }
};

		private List<Topic> clinicalSkillsTopics() => new List<Topic>
{
	new Topic
	{
		Title = "Introduction to Clinical Skills",
		About = "Overview of essential skills for healthcare professionals.",
		LectureDate = DateTime.Now.AddDays(1),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Patient Communication",
		About = "Developing effective communication techniques with patients.",
		LectureDate = DateTime.Now.AddDays(2),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Medical History Taking",
		About = "Mastering the art of collecting comprehensive patient medical histories.",
		LectureDate = DateTime.Now.AddDays(3),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Physical Examination Techniques",
		About = "Learning and practicing various physical examination techniques.",
		LectureDate = DateTime.Now.AddDays(4),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Vital Signs Assessment",
		About = "Understanding and measuring vital signs accurately.",
		LectureDate = DateTime.Now.AddDays(5),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Infection Control Practices",
		About = "Ensuring proper infection control measures in clinical settings.",
		LectureDate = DateTime.Now.AddDays(6),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Wound Care and Dressing Techniques",
		About = "Practical skills in wound assessment, cleaning, and dressing.",
		LectureDate = DateTime.Now.AddDays(7),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Medical Documentation",
		About = "Guidelines and best practices for accurate medical documentation.",
		LectureDate = DateTime.Now.AddDays(8),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Emergency Response and First Aid",
		About = "Developing skills for responding to medical emergencies and providing first aid.",
		LectureDate = DateTime.Now.AddDays(9),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    },
	new Topic
	{
		Title = "Professional Ethics in Healthcare",
		About = "Understanding and applying ethical principles in healthcare practice.",
		LectureDate = DateTime.Now.AddDays(10),
		CourseId = 5,
		NoteFiles = new List<NoteFile>(),  // Initialize as needed
        AssignmentFiles = new List<AssignmentFile>()  // Initialize as needed
    }
};

	}
}
