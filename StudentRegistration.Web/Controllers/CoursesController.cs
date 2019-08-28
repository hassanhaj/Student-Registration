using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Web.Models;

namespace StudentRegistration.Web.Controllers
{
    public class CoursesController : Controller
    {
        IStorageService svc;
        public CoursesController(IStorageService _svc)
        {
            svc = _svc;
        }

        public IActionResult Index()
        {
           
            var model = new CoursesHomeModel();
            model.Courses = svc.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]CourseModel courseModel)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            svc.Create(courseModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var courseModel = svc.Get(id);

            return View(courseModel);
        }
        [HttpPost]
        public IActionResult Edit(int id,[FromForm]CourseModel courseModel)
        {
            courseModel.Id = id;
            svc.Update(courseModel);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            svc.Delete(id);
            return RedirectToAction("Index");
        }
    }
}