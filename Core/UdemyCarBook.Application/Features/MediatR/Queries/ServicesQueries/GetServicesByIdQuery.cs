using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.ServicesResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ServicesQueries
{
    public class GetServicesByIdQuery :IRequest<GetServicesByIdQueryResult>
    {
        public GetServicesByIdQuery(int id)
        {
            Id = id;
        }

        public int  Id { get; set; }
    }
}
