using GinkStories.Application.UseCases.Users.SharedValidator;
using GinkStories.Communication.Requests;
using GinkStories.Exception.ExceptionsBase;
using GinkStories.Infrastructure.DataAccess;

namespace GinkStories.Application.UseCases.Users.Update;

public class UpdateUserUseCase
{
    public void Execute(int userId,RequestUserJson request)
    {
        Validate(request);

        var dbContext = new GinkStoriesDbContext();

        var entity=dbContext.users.FirstOrDefault(user => user.id == userId); //na tabela users, irá verificar se o Id do user é o mesmo que foi recebido como parametro (userId)

        if (entity is null)
        {
            throw new NotFoundException("Usuário não encontrado");
        }
        
        entity.name = request.Name;
        entity.email = request.Email;
        entity.password = request.Password;
        
        dbContext.users.Update(entity);
        dbContext.SaveChanges();
    }

    public void  Validate (RequestUserJson request)   //mesma validação do cadastro
    {
        var validator = new RequestUserValidator();
        
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errors);
        }
    }
}