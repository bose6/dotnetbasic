using lotus.Controllers.Userregistration.Dto;
using lotus.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lotus.Controllers.Userregistration
{
    [Route("api/[controller]")]
    [ApiController]
    public class USerController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserRegistrationDto userRegistrationDto)
        {
            return null;
        }
        
    }
}
