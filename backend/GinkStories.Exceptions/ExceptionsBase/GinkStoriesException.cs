namespace GinkStories.Exceptions.ExceptionsBase;
//classe de exceções customizadas
public abstract class GinkStoriesException : SystemException 
{
    public GinkStoriesException(string errorMessage) : base (errorMessage)  //base chama o ctor da classe SystemException
    {
        
    }

    public abstract List<string> GetErrors(); //função que as outras classes filhas de GinkStoriesException deverão implementar (obrigatoriamente)
}