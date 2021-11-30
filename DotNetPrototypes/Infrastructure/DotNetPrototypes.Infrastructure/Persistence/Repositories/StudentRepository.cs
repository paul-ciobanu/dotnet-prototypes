using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;
using DotNetPrototypes.Infrastructure.Persistence.Services;
using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Persistence.Repositories;

internal class StudentRepository : IStudentRepository
{
    private readonly IMongoDatabase _db;
    private readonly IMongoCollection<Student> _collection;

    public StudentRepository(IMongoClientProvider mongoClientProvider)
    {
        _db = mongoClientProvider.Client.GetDatabase("students");
        _collection = _db.GetCollection<Student>("students");
    }

    public async Task<Guid> Add(Student student)
    {
        await _collection.InsertOneAsync(student);
        return student.Id;
    }

    public async Task<Student> Delete(Guid studentId)
    {
        var student = await _collection.FindOneAndDeleteAsync(s => s.Id == studentId);
        return student;
    }

    public async Task<List<Student>> GetAll()
    {
        var students = await _collection.Find(_ => true).ToListAsync();
        return students;
    }
}
