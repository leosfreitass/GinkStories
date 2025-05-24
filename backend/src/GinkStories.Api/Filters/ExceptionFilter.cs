using GinkStories.Communication.Responses;
using GinkStories.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GinkStories.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is GinkStoriesException ginkStoriesException)  //exceção do tipo GinkStoriesException, se a exceção for desse tipo, irá fazer um casting para a variavel ginkStoriesException
        {
            context.HttpContext.Response.StatusCode = (int)ginkStoriesException.GetStatusCode(); //StatusCode é um inteiro e GetStatusCode é um enum. (int) é um casting.
            
            context.Result = new ObjectResult(new ResponseErrorMessagesJson(ginkStoriesException.GetErrors()));
            /*
             mesma lógica: 
             catch ( GinkStoriesException ex)
               {
                   var errors = ex.GetErrors();
                   return BadRequest(new ResponseErrorMessagesJson(errors));
               }
            */
             
        }
        else
        {
            ThrowUnkowError(context);
        }
    }
    
    private void ThrowUnkowError(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new ResponseErrorMessagesJson(context.Exception.Message));
    }
}