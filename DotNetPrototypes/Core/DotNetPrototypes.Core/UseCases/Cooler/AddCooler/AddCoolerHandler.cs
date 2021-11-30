using AutoMapper;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.Cooler.AddCooler;

internal class AddCoolerHandler : IRequestHandler<AddCoolerCommand, AddCoolerResponse>
{
    private readonly ICoolerRepository _coolerRepository;
    private readonly IMapper _mapper;

    public AddCoolerHandler(ICoolerRepository coolerRepository, IMapper mapper)
    {
        _coolerRepository = coolerRepository;
        _mapper = mapper;
    }

    public async Task<AddCoolerResponse> Handle(AddCoolerCommand request, CancellationToken cancellationToken)
    {
        var validator = new AddCoolerRequestValidator();
        validator.Validate(request.Data);

        var student = new Entities.Cooler
        {
            Id = Guid.NewGuid(),
            Name = request.Data.Name,
            Rpm = request.Data.Rpm
        };
        await _coolerRepository.Add(student);
        return _mapper.Map<AddCoolerResponse>(student);
    }
}
