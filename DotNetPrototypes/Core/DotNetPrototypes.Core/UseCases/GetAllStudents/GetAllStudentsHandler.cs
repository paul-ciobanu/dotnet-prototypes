using AutoMapper;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.GetAllStudents;

internal class GetAllStudentsHandler : IRequestHandler<GetAllStudentsCommand, GetAllStudentsResponse>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public GetAllStudentsHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<GetAllStudentsResponse> Handle(GetAllStudentsCommand request, CancellationToken cancellationToken)
    {
        var students = await _studentRepository.GetAll();

        return new GetAllStudentsResponse
        {
            Students = _mapper.Map<List<StudentDto>>(students)
        };
    }
}
