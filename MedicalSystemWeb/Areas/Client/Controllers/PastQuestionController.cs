using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystemWeb.Areas.Client.Controllers
{
	[Area("Client")]
	public class PastQuestionController : Controller
	{
        private readonly IUnitOfService _unitOfService;
        public PastQuestionController(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }

		public IActionResult Index()
		{
			return View();
            
		}

        public IActionResult Questions(int id)
        {
            Exam exam = _unitOfService.examService.GetExam(id);
            return View(exam);
        }

        public IActionResult GetAll()
        {
            List<Exam> result = _unitOfService.examService.GetExams().ToList();
            return Json(new
            {
                data = result
            });
        }
    }
}
