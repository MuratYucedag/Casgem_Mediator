﻿using Casgem_Mediator.DAL;
using Casgem_Mediator.MediatorPattern.Queries;
using Casgem_Mediator.MediatorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateByIdQueryResult>
    {
        private readonly Context _context;
        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIdQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock
            };
        }
    }
}
