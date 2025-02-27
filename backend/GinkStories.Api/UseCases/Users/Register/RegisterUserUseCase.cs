using GinkStories.Communication.Requests;
using GinkStories.Communication.Responses;
using GinkStories.Exceptions.ExceptionsBase;

namespace GinkStories.Api.UseCases.Users.Register;

public class RegisterUserUseCase
{
    public ResponseUserJson Execute(RequestUserJson request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList(); //percorre cada elemento da lista de errors do tipo failure e devolve transformado em lista de errors
            throw new ErrorOnValidationException(errors); //exceção da classe GinkStoriesException, ErrorOnValidationException tem herança com GinkStoriesException
        }
        return new ResponseUserJson();
    }
}