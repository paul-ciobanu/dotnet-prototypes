using FluentValidation;

namespace DotNetPrototypes.Core.UseCases.AddStudent;

public class AddStudentRequestValidator : AbstractValidator<AddStudentRequest>
{
    public AddStudentRequestValidator()
    {
        RuleFor(x => x.Name).Length(3, 60);
    }
}
