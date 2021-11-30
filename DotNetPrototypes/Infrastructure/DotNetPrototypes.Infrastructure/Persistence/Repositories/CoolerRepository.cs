using Dapper;
using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.Interfaces.Repositories;

namespace DotNetPrototypes.Infrastructure.Persistence.Repositories;

internal class CoolerRepository : ICoolerRepository
{
    private readonly DapperContext _context;

    public CoolerRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<Guid> Add(Cooler student)
    {
        using var connection = _context.CreateConnection();

        string sql = "INSERT INTO Coolers (Name, Rpm) OUTPUT Inserted.Id Values (@Name, @Rpm) ;";
        var result = await connection.ExecuteScalarAsync(sql, student);
        return Guid.Parse(result.ToString());
    }
}
