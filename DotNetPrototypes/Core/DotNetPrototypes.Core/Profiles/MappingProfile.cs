using AutoMapper;
using DotNetPrototypes.Core.Entities;
using DotNetPrototypes.Core.UseCases.AddStudent;
using DotNetPrototypes.Core.UseCases.Cooler.AddCooler;
using DotNetPrototypes.Core.UseCases.Cooler.GetAllCoolers;
using DotNetPrototypes.Core.UseCases.DeleteStudent;
using DotNetPrototypes.Core.UseCases.GetAllStudents;
using DotNetPrototypes.Core.UseCases.GetEvent;

namespace DotNetPrototypes.Core.Profiles;

internal class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student, AddStudentResponse>();
        CreateMap<Student, StudentDto>();
        CreateMap<Student, DeleteStudentResponse>();

        CreateMap<Event, GetEventResponse>();
        CreateMap<Event, UseCases.GetEvent.V2.GetEventResponse>()
            .ForMember(dest => dest.EventId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.Name));

        CreateMap<Cooler, AddCoolerResponse>();
        CreateMap<Cooler, CoolerDto>();
    }
}
