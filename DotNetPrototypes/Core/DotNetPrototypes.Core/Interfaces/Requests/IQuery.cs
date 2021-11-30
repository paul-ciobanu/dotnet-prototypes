using MediatR;

namespace DotNetPrototypes.Core.Interfaces.Requests;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}
