namespace GinkStories.Communication.Responses;
//classe para devolver menssagens de erro json
public class ResponseErrorMessagesJson
{
    public List<string> Errors { get; private set; }  //lista de erros

    public ResponseErrorMessagesJson(string message)  //construtor para evitar que a classe seja instanciada sem receber pelo menos 1 mensagem de erro.      recebendo uma mensagem como parametro
    {
        Errors = new List<string>{ message };     //esperando uma lista de string
    }

    public ResponseErrorMessagesJson(List<string> messages)  //construtor recebendo uma lista de string, diferente do construtor anterior que recebe pelo menos 1 string como parametro
    {
        Errors = messages;
    }
}