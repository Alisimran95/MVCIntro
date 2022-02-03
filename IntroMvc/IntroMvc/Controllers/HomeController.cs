using System.Collections.Generic;
using IntroMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMvc.Controllers
{
    public class HomeController :Controller
    {
        public IActionResult Index()
            {
                return View(Detail());
        }

        public IActionResult Detail()
        {
            var students = new List<Student>
            {
                new Student {Id = 1, Name = "Idris", Age = 25},
                new Student {Id = 2,Name = "Alisimran",Age = 26}
            };
            return View(students);
        }



    }
}
