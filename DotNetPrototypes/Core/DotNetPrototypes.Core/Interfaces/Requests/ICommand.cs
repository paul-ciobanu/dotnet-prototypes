using MediatR;

namespace DotNetPrototypes.Core.Interfaces.Requests;

public interface ICommand<TRequest, TResponse> : IRequest<TResponse>
{
    public TRequest Data { get; init; }
}
