using Casgem_Mediator.MediatorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
