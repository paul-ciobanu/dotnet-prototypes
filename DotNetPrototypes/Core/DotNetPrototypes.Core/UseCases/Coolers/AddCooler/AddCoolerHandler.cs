using AutoMapper;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.Coolers.AddCooler;

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

        var cooler = new Entities.Cooler
        {
            Name = request.Data.Name,
            Rpm = request.Data.Rpm
        };
        cooler.Id = await _coolerRepository.Add(cooler);
        return _mapper.Map<AddCoolerResponse>(cooler);
    }
}
