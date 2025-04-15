using coreApiC5.Server.DTO;
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

        [HttpGet("getStudentByName/{name}")]
        public IActionResult getStudentByName( string name)
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

        [HttpDelete("deleteStudent")]
        public IActionResult deleteStudent(int id)
        {
            var student = _data.deleteStudent(id);
            if (student != false)
            {

                return Ok();
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult addStudent([FromForm] studentRequestDTO studentData)
        {

            // presentation layer 
            if (studentData == null)
                return BadRequest();


            bool added = _data.addStudent(studentData);
            if (added == false)
                return BadRequest();
            else
                return StatusCode(201, studentData);

        }
        // routing parameters

        [HttpPut("editStudent/{id}")]
        public IActionResult editStudent(int id , [FromForm] studentRequestDTO student )
        {
            if(student == null)
                return BadRequest();
            else
            {
                bool updated = _data.editStudent(id, student);
                if (updated == false)
                    return BadRequest();
                else
                    return Ok();
            }


        } 

    }
}

