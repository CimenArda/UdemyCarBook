﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AuthorHandlers
{
	public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
	{
		private readonly IRepository<Author> _repository;

		public GetAuthorQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetAuthorQueryResult
			{
				AuthorId = x.AuthorId,
				AuthorName = x.AuthorName,
				Description = x.Description,
				ImageUrl = x.ImageUrl
			}).ToList();
		}
	}
}
