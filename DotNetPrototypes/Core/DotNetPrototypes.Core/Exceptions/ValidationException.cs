namespace DotNetPrototypes.Core.Exceptions;

public class ValidationException : Exception
{
    public ValidationException(string message, IReadOnlyCollection<string> errors) : base(message)
    {
        Errors = errors;
    }

    public IReadOnlyCollection<string> Errors { get; init; }
}
