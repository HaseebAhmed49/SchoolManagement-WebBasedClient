using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_WebClient.Models
{
	public class Course
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Credit HOUR is required")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }
    }
}

