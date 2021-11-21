using MediatR;

namespace DotNetPrototypes.Core.UseCases.AddStudent;

public class AddStudentCommand : IRequest<Guid>
{
    public string? Name { get; init; }
}
