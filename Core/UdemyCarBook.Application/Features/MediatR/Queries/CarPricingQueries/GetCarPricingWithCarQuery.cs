using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.CarPricingResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries
{
	public class GetCarPricingWithCarQuery :IRequest<List<GetCarPricingWithCarQueryResult>>
	{
	}
}
