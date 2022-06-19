﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_WebClient.Data.ViewModels
{
	public class CourseVM
	{
		public int id { get; set; }
		public string Title { get; set; }

		public int Credits { get; set; }

		public int DeparmentId { get; set; }
	}

	public class CoursewithInstructorVM
	{
        public int id { get; set; }

        public string Title { get; set; }

		public int Credits { get; set; }

		public List<string> InstructorNames { get; set; }
	}
}

