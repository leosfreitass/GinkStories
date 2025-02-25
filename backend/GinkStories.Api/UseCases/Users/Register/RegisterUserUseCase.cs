using GinkStories.Communication.Requests;
using GinkStories.Communication.Responses;

namespace GinkStories.Api.UseCases.Users.Register;

public class RegisterUserUseCase
{
    public ResponseUserJson Execute(RequestUserJson request)
    {
        var validator = new RegisterUserValidator();
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            throw new ArgumentException("ERRO NOS DADOS RECEBIDOS");
        }
        return new ResponseUserJson();
    }
}