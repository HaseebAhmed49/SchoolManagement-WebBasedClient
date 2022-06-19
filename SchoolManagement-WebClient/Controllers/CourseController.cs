using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagement_WebClient.Data;
using SchoolManagement_WebClient.Data.Services;
using SchoolManagement_WebClient.Data.ViewModels;
using SchoolManagement_WebClient.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagement_WebClient.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseServices _service;

        public CourseController(CourseServices service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var action = "api/Course/get-all-courses-with-instructors";
            var request = HttpClientCustom.client.GetAsync(action);
            var response = request.Result.Content.ReadAsAsync<List<CoursewithInstructorVM>>();
            return View(response.Result);
        }

        public async Task<IActionResult> Create()
        {
            var departmentDropdownsData = _service.GetInstructorDropdownsValues();

            ViewBag.Departments = new SelectList(departmentDropdownsData.departments, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseVM course)
        {
            if (!ModelState.IsValid)
            {
                var departmentDropdownsData = _service.GetInstructorDropdownsValues();
                ViewBag.Departments = new SelectList(departmentDropdownsData.departments, "Id", "Name");
                return View(course);
            }
            var action = "api/Course/add-course";
            var request = HttpClientCustom.client.PostAsJsonAsync(action, course);
            var response = await request.Result.Content.ReadAsStringAsync();
            Console.WriteLine(response.ToString());
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var action = $"api/Course/get-courses-with-instructors-by-id/{id}";
            var request = HttpClientCustom.client.GetAsync(action);
            var response = request.Result.Content.ReadAsStringAsync();
            if (response.Result == null) return View("Not Found");
            return View(response.Result);
        }

        [HttpDelete,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var action = $"api/Course/get-courses-with-instructors-by-id/{id}";
            var request = HttpClientCustom.client.GetAsync(action);
            var response = request.Result.Content.ReadAsStringAsync();
            if (response.Result == null) return View("Not Found");
            action = $"delete-course-by-id/{id}";
            request = HttpClientCustom.client.DeleteAsync(action);
            response = request.Result.Content.ReadAsStringAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}