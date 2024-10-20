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
	public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
	{
		private readonly IBlogRepository _repository;
		public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
		{
			_repository = repository;
		}
		public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetLast3BlogsWithAuthor();
			return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
			{
				AuthorId = x.AuthorId,
				BlogId = x.BlogId,
				CategoryId = x.CategoryId,
				CoverImageUrl = x.CoverImageUrl,
				CreatedDate = x.CreatedDate,
				Title = x.Title,
				AuthorName = x.Author.AuthorName
			}).ToList();
		}
	}
}
