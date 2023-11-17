using Buisness.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseInstructorsController : ControllerBase
    {
        ICourseInstructorService _courseInstructorService;

        public CourseInstructorsController(ICourseInstructorService courseInstructorService)
        {
            _courseInstructorService = courseInstructorService;
        }

        [HttpGet("getallcourseInstructor")]
        //[HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var result = _courseInstructorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addcourseInstructorService")]
        public IActionResult Addcourse(CourseInstructor courseInstructor )
        {
            var result = _courseInstructorService.Add(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletecourseInstructorService")]
        public IActionResult Deletecourse(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Delete(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecourseInstructorService")]
        public IActionResult Updatecourse(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Update(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _courseInstructorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
