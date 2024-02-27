using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Repositories
{
	public class ApplicationUserRepository:Repository<ApplicationUser>,IApplicationUserRepository
	{
		public ApplicationUserRepository(ApplicationDbContext db) : base(db)
		{

		}

	}
}
