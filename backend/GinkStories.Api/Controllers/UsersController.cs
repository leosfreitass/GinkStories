using GinkStories.Api.Communication;
using GinkStories.Api.Communication.Responses;
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
        public async Task<IActionResult> Post([FromBody] RequestUser request  )
        {
            var response = new ResponseUser()
            {
                Name = request.Name,
                Email = request.Email,
            };
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            //implementar metódo deletar
            return Ok($"DELETADO {id}");  
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] RequestUser request)
        {
            var response = new ResponseUser()
            {
                Id = id,
                Name = request.Name,
                Email = request.Email
            }; 
            //implementar metódo atualizar
            return Ok(response);
        }
        
    }
}
