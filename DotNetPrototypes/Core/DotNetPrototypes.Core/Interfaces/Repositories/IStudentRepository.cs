using DotNetPrototypes.Core.Entities;

namespace DotNetPrototypes.Core.Interfaces.Repositories;

public interface IStudentRepository
{
    Task<Guid> Add(Student student);
    Task<List<Student>> GetAll();
    Task<Student> Delete(Guid studentId);
}
