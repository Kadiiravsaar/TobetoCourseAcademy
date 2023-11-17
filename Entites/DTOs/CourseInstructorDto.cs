using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class CourseInstructorDto : IDto
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public string CourseName { get; set; }
        public string InstructorName { get; set; }
    }
}
