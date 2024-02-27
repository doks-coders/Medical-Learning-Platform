using MedicalSystem.ApplicationCore.Constants;
using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Infrastructure.Repository.Repositories;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedicalSystemWeb.Areas.Admin.Controllers
{

	[Area("Admin")]
    [Authorize(Roles = UserRoleConstants.Admin + "," + UserRoleConstants.StudentAdmin)]
    public class TopicController : Controller
	{
		private readonly IUnitOfService _unitOfService;
		public TopicController(IUnitOfService unitOfService)
		{
			_unitOfService = unitOfService;
		}
		// GET: CourseController
		public ActionResult Index()
		{
			IEnumerable<Topic> topics = _unitOfService.topicService.GetAllTopics();

			return View(topics);
		}

		// GET: CourseController/Create
		public ActionResult Upsert(int? id)
		{
            IEnumerable<SelectListItem> CourseList = _unitOfService.courseService.GetAllCourses().Select(el => new SelectListItem
            {
                Text = el.Name,
                Value = el.Id.ToString(),
            });
            ViewBag.CourseList = CourseList;

            if (id == null || id == 0)
			{
				Topic newTopic = new Topic();
				return View(newTopic);
			}
			Topic topic = _unitOfService.topicService.GetTopic(id);

			
			return View(topic);
		}


		// POST: CourseController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Upsert(Topic topic, IList<IFormFile> notefiles, IList<IFormFile> assignmentfiles)
		{
			try
			{
				if (topic.Id == null || topic.Id == 0)
				{
					_unitOfService.topicService.AddTopic(topic);
				}
				else
				{
					_unitOfService.topicService.UpdateTopic(topic);
					
				}
				if (assignmentfiles != null)
				{
                    _unitOfService.topicService.UploadAssignmentFiles(assignmentfiles, topic);
                }
				if(notefiles != null)
				{
                    _unitOfService.topicService.UploadNoteFiles(notefiles, topic);
                }
				
				
                return RedirectToAction(nameof(Index));

            }
			catch
			{
				return View();
			}
		}

		[HttpGet]
		public ActionResult GetAll()
		{
			List<Topic> courses = _unitOfService.topicService.GetAllTopics().ToList();

			return Json(new
			{
				data = courses
			});

		}

		// GET: CourseController/Delete/5
		[HttpDelete]
		public ActionResult Delete(int id)
		{
			_unitOfService.topicService.DeleteTopic(id);
			return Json(new
			{
				success = true
			});
		}

		// POST: CourseController/Delete/5

	}
}
