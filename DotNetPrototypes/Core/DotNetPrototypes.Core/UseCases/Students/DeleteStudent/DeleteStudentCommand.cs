using DotNetPrototypes.Core.Interfaces.Requests;

namespace DotNetPrototypes.Core.UseCases.Students.DeleteStudent;

public class DeleteStudentCommand : ICommand<DeleteStudentRequest, DeleteStudentResponse>
{
    public DeleteStudentRequest Data { get; init; }
}
