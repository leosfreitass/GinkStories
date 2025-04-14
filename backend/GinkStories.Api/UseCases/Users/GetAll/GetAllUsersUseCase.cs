using GinkStories.Api.Infrastructure;
using GinkStories.Communication.Responses;

namespace GinkStories.Api.UseCases.Users.GetAll;

public class GetAllUsersUseCase
{
    public ResponseAllUsersJson Execute()
    {
        var dbContext = new GinkStoriesDbContext();
        
        var users = dbContext.users.ToList();

        return new ResponseAllUsersJson
        {
            Users = users.Select(user => new ResponseShortUserJson
            {
                Id = user.id,
                Name = user.name,
                Email = user.email,
            }).ToList()
        };
    }
}