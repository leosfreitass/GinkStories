namespace GinkStories.Communication.Responses;
//classe para devolver menssagens de erro json
public class ResponseErrorMessages
{
    public List<string> Errors { get; private set; }  //lista de erros

    public ResponseErrorMessages(string message)  //construtor para evitar que a classe seja instanciada sem receber pelo menos 1 mensagem de erro
    {
        Errors = new List<string>{ message };
    }
}