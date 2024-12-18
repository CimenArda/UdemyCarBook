﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries;

namespace Udemy.CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarPricingsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CarPricingsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CarPricingWithCarList()
		{
			var values = await _mediator.Send(new GetCarPricingWithCarQuery());
			return Ok(values);
		}

		[HttpGet("GetCarPricingWithTimePeriodList")]
		public async Task<IActionResult> GetCarPricingWithTimePeriodList()
		{
			var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
			return Ok(values);
		}
	}
}
