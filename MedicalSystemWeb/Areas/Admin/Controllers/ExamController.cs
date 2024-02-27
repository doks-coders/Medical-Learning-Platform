using MedicalSystem.ApplicationCore.Constants;
using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystemWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoleConstants.Admin + "," + UserRoleConstants.StudentAdmin)]
    public class ExamController : Controller
    {
        private readonly IUnitOfService _unitOfService;
        public ExamController(IUnitOfService unitOfService)
        {
            _unitOfService = unitOfService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                Exam newExam =   new Exam();
                return View(newExam);
            }
            Exam exam = _unitOfService.examService.GetExam(id);
            return View(exam);
        }

        [HttpPost]
        public IActionResult Upsert(Exam exam, IList<IFormFile>? files)
        {
            if (exam.Id == 0)
            {
                //Save New Exam
                _unitOfService.examService.SaveExam(exam);
            }
            else
            {
                //Update New Exam
                _unitOfService.examService.UpdateExam(exam);
            }

            if (files != null)
            {
                _unitOfService.examService.UploadExamFiles(files,exam);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int?id)
        {
            _unitOfService.examService.DeleteExam(id);
            return Json(new
            {
                success=true
            });
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
