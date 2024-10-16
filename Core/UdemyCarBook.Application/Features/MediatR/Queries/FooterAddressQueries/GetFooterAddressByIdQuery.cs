﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.FooterAddressResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery :IRequest<GetFooterAddressByIdQueryResult>
    {
        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
