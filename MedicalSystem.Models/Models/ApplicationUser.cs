using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Models.Models
{
	public class ApplicationUser:IdentityUser
	{
		public string UserName { get; set; }

		[NotMapped]
		public string Role { get; set; }
	}
}
