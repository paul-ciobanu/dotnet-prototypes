using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.GetAllStudents;

internal class GetAllStudentsHandler : IRequestHandler<GetAllStudentsCommand, List<Student>>
{
    private readonly IStudentRepository _studentRepository;

    public GetAllStudentsHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<List<Student>> Handle(GetAllStudentsCommand request, CancellationToken cancellationToken)
    {
        return _studentRepository.GetAll();
    }
}
