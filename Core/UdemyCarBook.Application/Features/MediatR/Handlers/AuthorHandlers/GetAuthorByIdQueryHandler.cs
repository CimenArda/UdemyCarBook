using MediatR;
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
	public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
	{
		private readonly IRepository<Author> _repository;

		public GetAuthorByIdQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetAuthorByIdQueryResult
			{
				AuthorId = values.AuthorId,
				AuthorName = values.AuthorName,
				ImageUrl = values.ImageUrl,
				Description = values.Description
			};
		}
	}
}
