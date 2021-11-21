using AutoMapper;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.DeleteStudent;

internal class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, DeleteStudentResponse>
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public DeleteStudentHandler(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<DeleteStudentResponse> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        var id = request.Data.Id;
        var student = await _studentRepository.Delete(id);
        if (student == null)
        {
            throw new NotFoundException($"Student with id '{id}' not found.");
        }
        return _mapper.Map<DeleteStudentResponse>(student);
    }
}
