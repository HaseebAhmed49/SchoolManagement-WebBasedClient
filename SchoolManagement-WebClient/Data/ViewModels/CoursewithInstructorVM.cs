using System;
namespace SchoolManagement_WebClient.Data.ViewModels
{
	public class CoursewithInstructorVM
	{
		public string Title { get; set; }

		public int Credits { get; set; }

		public List<string> InstructorNames { get; set; }
	}
}

