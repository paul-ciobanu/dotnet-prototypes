using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Infrastructure.Interfaces.Persistence.Services;
using MongoDB.Driver;

namespace DotNetPrototypes.Infrastructure.Persistence.Repositories;

internal class StudentRepository
{
    private readonly IMongoDatabase _db;
    private readonly IMongoCollection<Student> _collection;

    public StudentRepository(IMongoClientProvider mongoClientProvider)
    {
        _db = mongoClientProvider.Client.GetDatabase("schools");
        _collection = _db.GetCollection<Student>("students");
    }

    public async Task Add(Student student)
    {
        await _collection.InsertOneAsync(student);
    }

    public async Task<List<Student>> GetAll()
    {
        throw new NotImplementedException();
    }
}
