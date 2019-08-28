using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Web.Entities;
using StudentRegistration.Web.Models;
using StudentRegistration.Web.Services;
using System.Linq;

namespace StudentRegistration.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsService _studentsService;
        private readonly CountryService _countryService;

        public StudentsController(StudentsService studentsService
            ,CountryService countryService)
        {
            this._studentsService = studentsService;
            this._countryService = countryService;
        }

        // GET: Student
        public ActionResult Index(int pageIndex = 1)
        {
            var pageSize = 5;
            var model = new StudentsHomeModel();
            model.Students = _studentsService.GetPage(pageIndex, pageSize);
            var list = model.Students.ToList();
            list.Add(new Student());
            return View(model);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            var studentVM = new StudentViewModel
            {
                Countries = _countryService.GetCountries()
            };
            return View(studentVM);
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                _studentsService.Create(student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _studentsService.Get(id);
            return View(model);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                _studentsService.Update(id, student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
                _studentsService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}