using AutoMapper;
using DotNetPrototypes.Core.Entities;
using MediatR;

namespace DotNetPrototypes.Core.UseCases.Events.GetEvent.V2;

internal class GetEventHandler : IRequestHandler<GetEventQuery, GetEventResponse>
{
    private readonly IMapper _mapper;

    public GetEventHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<GetEventResponse> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        var result = _mapper.Map<GetEventResponse>(Event.RandomEvent);
        return Task.FromResult(result);
    }
}
