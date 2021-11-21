using MediatR;

namespace DotNetPrototypes.Core.UseCases.DeleteStudent;

public class DeleteStudentCommand : IRequest<DeleteStudentResponse>
{
    public DeleteStudentRequest? Data { get; init; }
}
