﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands;
using UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;

namespace Udemy.CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BlogsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> BlogList()
		{
			var values = await _mediator.Send(new GetBlogQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBlog(int id)
		{
			var value = await _mediator.Send(new GetBlogByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Blog başarıyla eklendi");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> RemoveBlog(int id)
		{
			await _mediator.Send(new RemoveBlogCommand(id));
			return Ok("Blog başarıyla silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Blog başarıyla güncellendi");
		}

		[HttpGet("GetLast3BlogsWitAuthorsList")]
		public async Task<IActionResult> GetLast3BlogsWitAuthorsList()
		{
			var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
			return Ok(values);
		}

        [HttpGet("GetAllBlogsWitAuthorsList")]
        public async Task<IActionResult> GetAllBlogsWitAuthorsList()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogsByAuthorIdList")]
        public async Task<IActionResult> GetAllBlogsWitAuthorsList(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
