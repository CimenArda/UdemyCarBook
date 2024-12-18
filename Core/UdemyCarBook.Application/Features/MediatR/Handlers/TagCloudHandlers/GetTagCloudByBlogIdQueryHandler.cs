﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.TagCloudQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _repository;
        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagCloudByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                Title = x.Title,
                TagCloudID = x.TagCloudID,
                BlogId = x.BlogId
            }).ToList();
        }
    }
}
