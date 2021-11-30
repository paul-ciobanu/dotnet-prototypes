using MediatR;

namespace DotNetPrototypes.Core.UseCases.Students.AddStudent;

public class AddStudentCommand : IRequest<AddStudentResponse>
{
    public AddStudentRequest Data { get; init; }
}
