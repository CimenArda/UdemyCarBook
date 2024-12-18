﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
	public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

		public UpdateBlogCommandHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.BlogId);
			values.AuthorId = request.AuthorId;
			values.CategoryId = request.CategoryId;
			values.Title = request.Title;
			values.CreatedDate = request.CreatedDate;
			values.CoverImageUrl = request.CoverImageUrl;

			await _repository.UpdateAsync(values);
		}
	}
}
