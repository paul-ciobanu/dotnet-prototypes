using AutoMapper;
using DotNetPrototypes.Core.Interfaces.Repositories;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.Coolers.GetAllCoolers;

internal class GetAllCoolersHandler : IRequestHandler<GetAllCoolersCommand, GetAllCoolersResponse>
{
    private readonly ICoolerRepository _coolerRepository;
    private readonly IMapper _mapper;

    public GetAllCoolersHandler(ICoolerRepository coolerRepository, IMapper mapper)
    {
        _coolerRepository = coolerRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCoolersResponse> Handle(GetAllCoolersCommand request, CancellationToken cancellationToken)
    {
        var coolers = await _coolerRepository.GetAll();

        return new GetAllCoolersResponse
        {
            Coolers = _mapper.Map<List<CoolerDto>>(coolers)
        };
    }
}
