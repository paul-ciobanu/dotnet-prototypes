using DotNetPrototypes.Core.Entities;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.GetAllStudents;

public class GetAllStudentsCommand : IRequest<List<Student>>
{
}
