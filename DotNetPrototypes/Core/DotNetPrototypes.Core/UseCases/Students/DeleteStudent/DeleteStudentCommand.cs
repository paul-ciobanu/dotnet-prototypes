using MediatR;

namespace DotNetPrototypes.Core.UseCases.Students.DeleteStudent;

public class DeleteStudentCommand : IRequest<DeleteStudentResponse>
{
    public DeleteStudentRequest Data { get; init; }
}
