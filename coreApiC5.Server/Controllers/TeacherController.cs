using coreApiC5.Server.IDataService;

using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace coreApiC5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // presentation layer 
    public class TeacherController : ControllerBase
    {
        private readonly IDataServicee _data;
        public TeacherController(IDataServicee data)
        {
            _data = data;

        }


        //[HttpGet]
        //public IActionResult getTeachers()
        //{
        //    var teachers = _data.getTeachers();
        //    return Ok(teachers);
        //}

        //[HttpGet("getTeacherById/{id}")]
        //public IActionResult getTeacherById(int id)
        //{
        //    var teacher = _data.getTeacherById(id);
        //    return Ok(teacher);
        //}

        //[HttpGet("getTeacherByName/{name}")]
        //public IActionResult getTeacherByName(string name)
        //{
        //    var teacher = _data.getTeacherByName(name);
        //    return Ok(teacher);
        //}


        //[HttpDelete]
        //public IActionResult deleteTeacher(int id)
        //{

        //    var teacher = _data.deleteTeacher(id); // var ==> int , bool , string 
        //    if (teacher == true)
        //    {

        //        return NoContent();
        //    }

        //    return NotFound();

        //}

        [HttpGet("MyTeachers")]
        public IActionResult Get_ALL_Teachers_From_OMar()
        {
            var teachers = _data.Get_ALL_Teachers_From_OMar();
            return Ok(teachers);
        }

        [HttpGet("teacherByID/{id}")]
        public IActionResult getTeacherByID(int id)
        {
            var teacher = _data.getTeacherByID( id);
            return Ok(teacher);
        }

        [HttpGet("getTeacherByName/{name}")]
        public IActionResult getTeacherByNameSura(string name)
        {
            var teacher = _data.getTeacherByNameSura(name);
            return Ok(teacher);
        }

        [HttpDelete("DeleteTeacher/{id}")]
        public IActionResult deleteTeacherByID(int id) { 
            var teacher = _data.deleteTeacherHani(id);
            return Ok(teacher);
        
        }

    }
}
