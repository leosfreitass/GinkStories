using GinkStories.Api.Entities;
using GinkStories.Api.Infrastructure;
using GinkStories.Communication.Requests;
using GinkStories.Communication.Responses;
using GinkStories.Exceptions.ExceptionsBase;

namespace GinkStories.Api.UseCases.Users.Register;

public class RegisterUserUseCase
{
    public ResponseShortUserJson Execute(RequestUserJson request)
    {
        Validate(request);

        var dbContext = new GinkStoriesDbContext();
        var entity = new User
        {
            name = request.Name,
            email = request.Email,
            password = request.Password,
            deleted = false,
        };
        dbContext.users.Add(entity);
        dbContext.SaveChanges();
        
        return new ResponseShortUserJson()
        {
            Id = entity.id,
            Name = entity.name,
        };
    }

    private void Validate(RequestUserJson request)
    {
        var validator = new RequestUserValidator();
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList(); //percorre cada elemento da lista de errors do tipo failure e devolve transformado em lista de errors
            throw new ErrorOnValidationException(errors); //exceção da classe GinkStoriesException, ErrorOnValidationException tem herança com GinkStoriesException
        }
    }
}