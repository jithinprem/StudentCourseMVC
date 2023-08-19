using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentCourseMvc;
using StudentCourseMvc.Models;

namespace StudentCourseMvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IRepository<Course> _repository;

        public CoursesController(IRepository<Course> repository)
        {
            _repository = repository;
        }

        public IActionResult Index() { 

            return View(_repository.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Course course) {

            _repository.Add(course);
            return View("Index", _repository.GetAll());
        }

        

        [HttpGet]
        public IActionResult Update(int id) {

            var course = _repository.GetById(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Update(Course course) {
            
            _repository.Update(course);
            return View("Index", _repository.GetAll());
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return View("Index", _repository.GetAll());
        }


      
    }
}
