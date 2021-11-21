using AutoMapper;
using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Exceptions;
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
        var results = validator.Validate(request.Data);
        if (results.Errors.Any())
            throw new ValidationException("error validating payload", results.Errors.Select(e => e.ErrorMessage).ToList().AsReadOnly());

        var student = new Student
        {
            Id = Guid.NewGuid(),
            Name = request.Data?.Name,
        };
        await _studentRepository.Add(student);
        return _mapper.Map<AddStudentResponse>(student);
    }
}
