using AutoMapper;
using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.UseCases.AddStudent;
using DotNetPrototypes.Core.UseCases.DeleteStudent;
using DotNetPrototypes.Core.UseCases.GetAllStudents;

namespace DotNetPrototypes.Core.Profiles;

internal class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student, AddStudentResponse>();
        CreateMap<Student, StudentDto>();
        CreateMap<Student, DeleteStudentResponse>();
    }
}