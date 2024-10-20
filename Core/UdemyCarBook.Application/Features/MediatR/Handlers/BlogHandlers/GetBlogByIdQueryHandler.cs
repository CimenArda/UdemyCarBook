using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
	public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
	{
		private readonly IRepository<Blog> _repository;

		public GetBlogByIdQueryHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetBlogByIdQueryResult
			{
				BlogId = values.BlogId,
				CreatedDate = values.CreatedDate,
				CoverImageUrl = values.CoverImageUrl,
				CategoryId = values.CategoryId,
				AuthorId = values.AuthorId,
				Title = values.Title,
				Description=values.Description,
				
			};
		}
	}
}
