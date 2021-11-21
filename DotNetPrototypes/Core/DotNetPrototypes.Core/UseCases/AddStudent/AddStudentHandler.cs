using AutoMapper;
using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.AddStudent;

internal class AddStudentHandler : IRequestHandler<AddStudentCommand, AddStudentResponse>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public AddStudentHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<AddStudentResponse> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var validator = new AddStudentRequestValidator();
        validator.Validate(request.Data);

        var student = new Student
        {
            Id = Guid.NewGuid(),
            Name = request.Data?.Name,
        };
        await _studentRepository.Add(student);
        return _mapper.Map<AddStudentResponse>(student);
    }
}
