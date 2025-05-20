using GinkStories.Api.Infrastructure;
using GinkStories.Exception.ExceptionsBase;

namespace GinkStories.Api.UseCases.Users.Delete;

public class DeleteUserUseCase
{
    public void Execute(int id)
    {
        var dbContext = new GinkStoriesDbContext();
        
        var entity = dbContext.users.FirstOrDefault(user => user.id == id); //verifica se o id é o mesmo recebido como parametro

        if (entity is null)
        {
            throw new NotFoundException("User not found");
        }
        
        entity.deleted = true;
        
        dbContext.Update(entity);
        dbContext.SaveChanges();
    }
}