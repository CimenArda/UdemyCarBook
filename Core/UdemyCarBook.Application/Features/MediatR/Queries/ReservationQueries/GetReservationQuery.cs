using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.ReservationResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ReservationQueries
{
    public class GetReservationQuery :IRequest<List<GetReservationQueryResult>>
    {
    }
}
