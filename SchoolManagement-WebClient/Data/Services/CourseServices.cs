using System;
using SchoolManagement_WebClient.Data.ViewModels;
using SchoolManagement_WebClient.Models;

namespace SchoolManagement_WebClient.Data.Services
{
	public class CourseServices
	{
        public DepartmentDropDownVM GetInstructorDropdownsValues()
        {
            DepartmentDropDownVM departmentDropDownVM = new DepartmentDropDownVM();
            var action = "api/Department/get-all-departments";
            var request = HttpClientCustom.client.GetAsync(action);
            var response = request.Result.Content.ReadAsAsync<List<Department>>();
            if(response.Result.Count > 0)
            {
                departmentDropDownVM.departments = response.Result;
            }
            return departmentDropDownVM;
        }

    }
}

