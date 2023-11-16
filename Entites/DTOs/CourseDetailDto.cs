using Core.Entities;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CourseDetailDto : IDto
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public string CategoryName { get; set; }
        public double Price { get; set; }
    }
}
