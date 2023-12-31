﻿using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        IDataResult<List<CourseInstructor>> GetAll();
        //IDataResult<List<CourseInstructorDto>> GetAllDetail();
        IDataResult<CourseInstructor> GetById(int courseInstructorId);
        IResult Add(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
    }
}
