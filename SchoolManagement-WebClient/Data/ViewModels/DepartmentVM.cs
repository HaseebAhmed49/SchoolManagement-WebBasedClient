using System;
namespace SchoolManagement_WebClient.Data.ViewModels
{
    public class DepartmentVM
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int Budget { get; set; }

        public DateTime StartDate { get; set; }
    }

    public class DepartmentWithCoursesVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Budget { get; set; }

        public DateTime StartDate { get; set; }

        public List<string> CoursesTitle { get; set; }
    }
}

