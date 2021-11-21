using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.AddStudent;

internal class AddStudentHandler : IRequestHandler<AddStudentCommand, Guid>
{
    private readonly IStudentRepository _studentRepository;

    public AddStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<Guid> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var student = new Student
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
        };
        return _studentRepository.Add(student);
    }
}
