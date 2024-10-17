﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.PricingResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.PricingQueries
{
    public class GetPricingQuery :IRequest<List<GetPricingQueryResult>>
    {
    }
}