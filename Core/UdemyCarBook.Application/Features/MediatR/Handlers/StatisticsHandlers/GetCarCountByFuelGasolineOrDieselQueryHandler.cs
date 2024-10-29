using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByFuelGasolineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, GetCarCountByFuelGasolineOrDiselQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelGasolineOrDiselQueryResult> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelGasolineOrDisel();
            return new GetCarCountByFuelGasolineOrDiselQueryResult
            {
                GetCarCountByFuelGasolineOrDisel = value
            };
        }
    }
}
