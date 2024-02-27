using MedicalSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Interfaces
{
	public interface ITopicRepository:IRepository<Topic>
	{
		void Update(Topic topic);
	}
}
