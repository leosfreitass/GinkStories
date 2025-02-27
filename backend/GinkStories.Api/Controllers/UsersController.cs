using GinkStories.Api.UseCases.Users.Register;
using GinkStories.Communication.Requests;
using GinkStories.Communication.Responses;
using GinkStories.Exceptions.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace GinkStories.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get( int id, RequestUserJson request)
        {
            var response = new ResponseUserJson()
            {
                Id = id,
                Email = request.Email,
                Name = request.Name,
            };
            return Ok(response);

        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseUserJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] RequestUserJson request  )
        {
            /*
            var response = new ResponseUserJson()
            {
                Name = request.Name,
                Email = request.Email,
            };
            */

            try
            {
                var useCase = new RegisterUserUseCase();
                var response = useCase.Execute(request);

                return
                    Created(string.Empty,
                        response); //status created precisa passar dois parametros para não ter erro, defini um parametro vazio e outro passando a response
            }
            catch ( GinkStoriesException ex)
            {
                var errors = ex.GetErrors();
                return BadRequest(new ResponseErrorMessagesJson(errors));
            }
            catch 
            {
               return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessagesJson("ERRO DESCONHECIDO"));
            }
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
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] RequestUserJson request)
        {
            var response = new ResponseUserJson()
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
