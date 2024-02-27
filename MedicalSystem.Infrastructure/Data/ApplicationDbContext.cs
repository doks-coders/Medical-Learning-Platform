using MedicalSystem.Infrastructure.Seeds;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Exam> Exams { get; set; }
		public DbSet<ExamFile> ExamFiles { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<AssignmentFile> AssignmentFiles { get; set; }
		public DbSet<NoteFile> NoteFiles { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Exam>().HasData(new ExamSeed().GetExamSeedData().ToArray());

			modelBuilder.Entity<Course>().HasData(new CourseSeed().GetCourseSeedData().ToArray());

			modelBuilder.Entity<Topic>().HasData(new TopicSeed().GetSeedData().ToArray());
		}
	}
}
