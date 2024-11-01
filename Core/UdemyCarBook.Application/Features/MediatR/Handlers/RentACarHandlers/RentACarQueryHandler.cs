using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.RentACarQueries;
using UdemyCarBook.Application.Features.MediatR.Results.RentACarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.RentACarHandlers
{
    public class RentACarQueryHandler : IRequestHandler<RentACarQuery, List<RentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public RentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<RentACarQueryResult>> Handle(RentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationId&& x.Available == true);
            var results = values.Select(y => new RentACarQueryResult
            {
                CarId = y.CarID,
                Brand = y.Car.Brand.Name,
                Model = y.Car.Model,
                CoverImageUrl = y.Car.CoverImageUrl
            }).ToList();
            return results;
        }
    }
}
