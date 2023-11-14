﻿using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCourseInstructorDal : EfEntityBaseRepository<CourseInstructor, AppDbContext>, ICourseInstructorDal
    {
    }
}
