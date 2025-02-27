namespace GinkStories.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : GinkStoriesException
{
    private readonly List<string> _errors; //a lista só pode ser alterada dentro do construtor
    public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
    {
        _errors = errorMessages;
    }

    public override List<string> GetErrors()
    {
        return _errors;
    }
}