using System;
namespace SchoolManagement_WebClient.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Budget { get; set; }

        public DateTime StartDate { get; set; }

        public List<Course> Courses { get; set; }
    }
}

