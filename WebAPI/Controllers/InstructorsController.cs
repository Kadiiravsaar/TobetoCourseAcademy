using Buisness.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService ınstructorService)
        {
            _instructorService = ınstructorService;
        }

        [HttpGet("getallInstructors")]
        public IActionResult GetAll()
        {
            var result = _instructorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addInstructor")]
        public IActionResult AddInstructor(Instructor instructor)
        {
            var result = _instructorService.Add(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteInstructor")]
        public IActionResult DeleteInstructor(Instructor instructor)
        {
            var result = _instructorService.Delete(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateInstructor")]
        public IActionResult UpdateInstructor(Instructor instructor)
        {
            var result = _instructorService.Update(instructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _instructorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
