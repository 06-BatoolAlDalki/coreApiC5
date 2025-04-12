using coreApiC5.Server.IDataService;
using coreApiC5.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApiC5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IDataServicee _data;

       public StudentController(IDataServicee data)
        {
            _data = data;
        }


        [HttpGet("getStudents")]
        public IActionResult getAllStudent()
        {
            var students = _data.getAllStudent();
            return Ok(students);
        }

        [HttpGet("getStudentById/{id}")]
        public IActionResult getStudentById(int id)
        {
            var student = _data.getStudentById(id);
            if (student != null)
            {
                return Ok(student); //200
            }
            else
            {
                return NotFound();//404
            }
        }

        [HttpGet("getStudentByName")]
        public IActionResult getStudentByName([FromQuery] string name)
        {
            var students = _data.getStudentByName(name);
            if (students != null)
            {
                return Ok(students);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("firstStudent")]
        public IActionResult getFirstStudent()
        {
            var student = _data.getFirstStudent();

            return Ok(student);

        }

        [HttpDelete("delete student")]
        public IActionResult deleteStudent(int id)
        {
            var student = _data.deleteStudent(id);
            if (student != false)
            {

                return Ok();
            }
            return NotFound();

        }


    }
}

