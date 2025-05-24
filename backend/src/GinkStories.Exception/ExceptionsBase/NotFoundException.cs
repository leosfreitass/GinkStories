using System.Net;

namespace GinkStories.Exception.ExceptionsBase;

public class NotFoundException : GinkStoriesException
{
    public NotFoundException(string errorMessage) : base(errorMessage) //o construtor irá receber como mensagem (texto) no parametro e irá repassar para GinkStoriesException que irá repassar para Exception
    {
    }

    public override List<string> GetErrors() => [Message]; //devolve lista de errors
    public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound; 
}