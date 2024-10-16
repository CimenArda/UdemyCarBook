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
    public class CreateServicesCommandHandler : IRequestHandler<CreateServicesCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServicesCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Description = request.Description,
                Title = request.Title,
                IconUrl = request.IconUrl
            });
        }
    }
}
