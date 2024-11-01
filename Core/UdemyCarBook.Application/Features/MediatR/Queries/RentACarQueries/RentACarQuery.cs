using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.RentACarResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.RentACarQueries
{
    public class RentACarQuery :IRequest<List<RentACarQueryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}
