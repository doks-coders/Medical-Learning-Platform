using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystemWeb.Areas.Client.Controllers
{
	[Area("Client")]
	public class ViewNotesController : Controller
	{
		private readonly IUnitOfService _unitOfService;
		public ViewNotesController(IUnitOfService unitOfService)
		{
			_unitOfService=unitOfService;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ViewTopics(int courseId)
		{
			List<Topic> topics = _unitOfService.topicService.GetAllCourseTopics(courseId).OrderBy(u=>u.LectureDate).ToList();
			return View(topics);
		}

		public IActionResult TopicPage(int id)
		{
			Topic topic = _unitOfService.topicService.GetTopic(id);
			return View(topic);
		}
		public IActionResult GetAll()
		{
			List<Course> courses =	_unitOfService.courseService.GetAllCourses().ToList();
			return Json(new
			{
				data = courses
			});

		}

	}
}
