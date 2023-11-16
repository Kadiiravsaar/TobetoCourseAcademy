using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class InstructorDto : IDto
    {
        public List<CourseDetailDto> courseDetailDtos { get; set; }
        public string InsName { get; set; }
    }
}
