using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery :IRequest<GetFeatureByIdQueryResult>
    {
        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
