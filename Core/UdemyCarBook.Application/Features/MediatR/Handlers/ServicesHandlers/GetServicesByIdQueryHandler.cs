using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.ServicesQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ServicesResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServicesHandlers
{
    public class GetServicesByIdQueryHandler : IRequestHandler<GetServicesByIdQuery, GetServicesByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServicesByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServicesByIdQueryResult> Handle(GetServicesByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServicesByIdQueryResult
            {
                ServiceID = values.ServiceID,
                IconUrl = values.IconUrl,
                Title = values.Title,
                Description = values.Description
            };
        }
    }
}
