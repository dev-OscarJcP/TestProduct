using BackEndTestProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndTestProduct.Controllers
{
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet("{Nif}")]
        public IActionResult GetById(int Nif)
        {
            return Ok(Nif);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { nif = createUserModel.Nif }, createUserModel);
        }
        [HttpPut("{Nif}/login")]
        public IActionResult Put(int Nif, [FromBody] CreateUserModel createUserModel)
        {
            if (Nif != createUserModel.Nif)
            {
                return BadRequest("NIF mismatch");
            }
            return NoContent();
        }
        [HttpDelete("{Nif}")]
        public IActionResult Delete(int Nif)
        {
            return NoContent();
        }
    }
}
