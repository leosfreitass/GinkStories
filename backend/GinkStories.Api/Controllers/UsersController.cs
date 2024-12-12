using GinkStories.Api.Communication;
using GinkStories.Api.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GinkStories.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = new ResponseUser()
            {
                Id = 1,
                Email = "admin@gmail.com",
                Name = "Admin",
            };
            return Ok(result);

        }

        [HttpPost]
        [Route("Cadastrar/{Name}")]
        
        public async Task<IActionResult> Post([FromRoute]string Name, [FromBody] RequestUser  )
        {
            return Ok(request);
        }
    }
}
