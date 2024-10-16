using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.ServicesCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.ServicesQueries;

namespace Udemy.CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServicesList()
        {
            var values = await _mediator.Send(new GetServicesQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServices(int id)
        {
            var value = await _mediator.Send(new GetServicesByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateServices(CreateServicesCommand command)
        {
            await _mediator.Send(command);
            return Ok("Services başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveServices(int id)
        {
            await _mediator.Send(new RemoveServicesCommand(id));
            return Ok("Services başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateServices(UpdateServicesCommand command)
        {
            await _mediator.Send(command);
            return Ok("Services başarıyla güncellendi");
        }
    }
}
