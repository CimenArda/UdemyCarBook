using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Commands.ServicesCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServicesHandlers
{
    public class RemoveServicesCommandHandler : IRequestHandler<RemoveServicesCommand>
    {
        private readonly IRepository<Service> _repository;

        public RemoveServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveServicesCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
