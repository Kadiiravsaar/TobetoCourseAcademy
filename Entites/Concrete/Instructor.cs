﻿using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
