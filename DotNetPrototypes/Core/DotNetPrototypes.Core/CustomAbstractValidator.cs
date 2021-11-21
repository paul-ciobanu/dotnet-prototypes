using FluentValidation;
using FluentValidation.Results;

namespace DotNetPrototypes.Core;

public class CustomAbstractValidator<T> : AbstractValidator<T>
{
    public override ValidationResult Validate(ValidationContext<T> context)
    {
        var validationResult = base.Validate(context);

        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList().AsReadOnly();
            throw new Exceptions.ValidationException("error validating payload", errors);
        }

        return validationResult;
    }
}
