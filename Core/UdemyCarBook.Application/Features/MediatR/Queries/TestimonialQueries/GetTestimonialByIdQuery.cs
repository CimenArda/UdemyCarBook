﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.TestimonialResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery :IRequest<GetTestimonialByIdQueryResult>
    {
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }

        public int  Id { get; set; }
    }
}
