namespace DotNetPrototypes.Core.UseCases.Students.GetAllStudents;

public class GetAllStudentsResponse
{
    public List<StudentDto> Students { get; set; }
}

public class StudentDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
