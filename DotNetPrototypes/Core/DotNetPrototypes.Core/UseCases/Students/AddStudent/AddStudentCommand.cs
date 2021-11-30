using DotNetPrototypes.Core.Interfaces.Requests;

namespace DotNetPrototypes.Core.UseCases.Students.AddStudent;

public class AddStudentCommand : ICommand<AddStudentRequest, AddStudentResponse>
{
    public AddStudentRequest Data { get; init; }
}
