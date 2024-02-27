using MedicalSystem.ApplicationCore.Constants;
using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystemWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = UserRoleConstants.Admin+","+UserRoleConstants.StudentAdmin)]
	public class CourseController : Controller
	{
		private readonly IUnitOfService _unitOfService;
		public CourseController(IUnitOfService unitOfService) 
		{
			_unitOfService = unitOfService;
		}
		// GET: CourseController
		public ActionResult Index()
		{
			IEnumerable<Course> courses = _unitOfService.courseService.GetAllCourses();

			return View(courses);
		}

		// GET: CourseController/Create
		public ActionResult Upsert(int?id)
		{
			if(id == null || id == 0)
			{
				Course newCourse = new Course();
				return View(newCourse);
			}

			Course course = _unitOfService.courseService.GetCourse(id);
			return View(course);
		}


		// POST: CourseController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Upsert(Course course)
		{
			try
			{
				if(course.Id==null || course.Id==0)
				{
					_unitOfService.courseService.AddCourse(course);
					return RedirectToAction(nameof(Index));
				}
				else
				{
					_unitOfService.courseService.UpdateCourse(course);
					return RedirectToAction(nameof(Index));
				}
				
			}
			catch
			{
				return View();
			}
		}

		[HttpGet]
		public ActionResult GetAll()
		{
			List<Course> courses = _unitOfService.courseService.GetAllCourses().ToList();

			return Json(new
			{
				data = courses
			});

		}

		// GET: CourseController/Delete/5
		[HttpDelete]
		public ActionResult Delete(int id)
		{
			_unitOfService.courseService.DeleteCourse(id);
			return Json(new
			{
				success = true
			});
		}

		// POST: CourseController/Delete/5
		
	}
}
