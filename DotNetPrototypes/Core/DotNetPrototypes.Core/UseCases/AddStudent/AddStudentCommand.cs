using MediatR;

namespace DotNetPrototypes.Core.UseCases.AddStudent;

public class AddStudentCommand : IRequest<AddStudentResponse>
{
    public AddStudentRequest? Data { get; init; }
}
