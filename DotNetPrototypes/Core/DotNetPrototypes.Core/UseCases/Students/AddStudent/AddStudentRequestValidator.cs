using FluentValidation;

namespace DotNetPrototypes.Core.UseCases.Students.AddStudent;

public class AddStudentRequestValidator : CustomAbstractValidator<AddStudentRequest>
{
    public AddStudentRequestValidator()
    {
        RuleFor(x => x.Name).Length(3, 60);
    }
}
