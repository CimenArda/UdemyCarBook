﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                AuthorId = x.AuthorId,
                BlogId = x.BlogId,
                AuthorName = x.Author.AuthorName,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
            }).ToList();
        }
    }
}
