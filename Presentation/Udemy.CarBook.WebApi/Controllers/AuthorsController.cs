﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries;

namespace Udemy.CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public AuthorsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> AuthorList()
		{
			var values = await _mediator.Send(new GetAuthorQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetAuthor(int id)
		{
			var value = await _mediator.Send(new GetAuthorByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
		{
			await _mediator.Send(command);
			return Ok("Author başarıyla eklendi");
		}
		[HttpDelete]
		public async Task<IActionResult> RemoveAuthor(int id)
		{
			await _mediator.Send(new RemoveAuthorCommand(id));
			return Ok("Author başarıyla silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
		{
			await _mediator.Send(command);
			return Ok("Author başarıyla güncellendi");
		}
	}
}
