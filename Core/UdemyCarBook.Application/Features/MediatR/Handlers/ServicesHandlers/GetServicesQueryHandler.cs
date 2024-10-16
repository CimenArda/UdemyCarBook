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
    public class GetServicesQueryHandler : IRequestHandler<GetServicesQuery, List<GetServicesQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServicesQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServicesQueryResult>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServicesQueryResult
            {
                ServiceID = x.ServiceID,
                Description = x.Description,
                Title = x.Title,
                IconUrl = x.IconUrl
            }).ToList();
        }
    }
}
