using coreApiC5.Server.DTO;
using coreApiC5.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApiC5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDataServicee _data;

        public UsersController(IDataServicee data)
        {
            _data = data;
        }


        [HttpPost("Login")]
        [ProducesResponseType(202)]
        [ProducesResponseType(201)]
        [ProducesResponseType(203)]
        [ProducesResponseType(204)]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(402)]
        [ProducesResponseType(404)]
        [ProducesResponseType(405)]
        public IActionResult login(loginUserDTO user)
        {

            if (user.Email == null || user.Password == null)
            {
                return BadRequest();
            }

            bool exist = _data.Login(user);
            if (exist)
            {
                return Ok();
            }
            else
            {

                return NotFound();
            }
        }


        [HttpPost]
        [ProducesResponseType(201)]
        public IActionResult Register(addUserDTO user)
        {
            if (user == null)
            {
                return NoContent();
            }

            bool data = _data.Register(user);
            if (data == false)
                return BadRequest();
            else
                return StatusCode(201, user);
        }

    }
}
