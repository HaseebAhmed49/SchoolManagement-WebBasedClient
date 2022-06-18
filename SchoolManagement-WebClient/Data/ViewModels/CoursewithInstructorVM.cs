using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_WebClient.Data.ViewModels
{
	public class CourseVM
	{
		public string Title { get; set; }

		public int Credits { get; set; }

		public int DeparmentId { get; set; }
	}

	public class CoursewithInstructorVM
	{
		public string Title { get; set; }

		public int Credits { get; set; }

		public List<string> InstructorNames { get; set; }
	}
}

