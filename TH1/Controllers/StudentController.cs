﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TH1.Models;

namespace TH1.Controllers
{
    [Route("Admin/Student")]      
    
    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>();
        public StudentController() 
        {
            students = new List<Student>()
            {
                new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT, Gender = Gender.Male,
                IsRegular=true,
                Address = "A1-2018", Email = "nam@g.com" },
                new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE, Gender = Gender.Female,
                IsRegular=true,
                Address = "A1-2019", Email = "tu@g.com" },
                new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE, Gender = Gender.Male,
                IsRegular=false,
                Address = "A1-2020", Email = "phong@g.com" },
                new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE, Gender = Gender.Female,
                IsRegular = false,
                Address = "A1-2021", Email = "mai@g.com" }
            };
        }
        [Route("Add")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranch = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT",  Value ="1"},
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = students.Last<Student>().Id + 1;
            students.Add(s);

            return View("Index", students);
        }

        [Route("List")]
        public IActionResult Index()
        {
            return View(students);
        }
    }
}
