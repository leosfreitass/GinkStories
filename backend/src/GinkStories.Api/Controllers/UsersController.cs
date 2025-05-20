using GinkStories.Api.UseCases.Users.Delete;
using GinkStories.Api.UseCases.Users.GetAll;
using GinkStories.Api.UseCases.Users.Register;
using GinkStories.Api.UseCases.Users.Update;
using GinkStories.Communication.Requests;
using GinkStories.Communication.Responses;
using GinkStories.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace GinkStories.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllUsersJson),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAll()
        {
           /* var response = new ResponseShortUserJson()
            {
                Id = id,
                Email = request.Email,
                Name = request.Name,
            };
            */

           var useCase = new GetAllUsersUseCase();
           var response = useCase.Execute();

           if (response.Users.Count == 0)
           {
               return NoContent();
           }
           
           return Ok(response);

        }
        

        [HttpPost]
        [ProducesResponseType(typeof(ResponseShortUserJson), StatusCodes.Status201Created)]
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

            var useCase = new RegisterUserUseCase();
            var response = useCase.Execute(request);

            return
                Created(string.Empty,
                    response); //status created precisa passar dois parametros para não ter erro, defini um parametro vazio e outro passando a response
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var useCase = new DeleteUserUseCase();
            useCase.Execute(id);
            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson),StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status404NotFound)]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] RequestUserJson request)
        {   /*
            var response = new ResponseShortUserJson()
            {
                Id = id,
                Name = request.Name,
                Email = request.Email
            }; 
            //implementar metódo atualizar*/
            var useCase = new UpdateUserUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }
        
    }
}
