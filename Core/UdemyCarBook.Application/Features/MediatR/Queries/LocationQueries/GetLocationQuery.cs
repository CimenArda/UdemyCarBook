using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.LocationResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries
{
    public class GetLocationQuery :IRequest<List<GetLocationQueryResult>>
    {
    }
}
