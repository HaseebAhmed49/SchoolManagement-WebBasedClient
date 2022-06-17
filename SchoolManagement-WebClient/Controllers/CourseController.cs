using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement_WebClient.Data;
using SchoolManagement_WebClient.Data.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagement_WebClient.Controllers
{
    public class CourseController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var action = "api/Course/get-all-courses-with-instructors";
            var request = HttpClientCustom.client.GetAsync(action);
            var response = request.Result.Content.ReadAsAsync<List<CoursewithInstructorVM>>();
            return View(response.Result);

        }
    }
}

