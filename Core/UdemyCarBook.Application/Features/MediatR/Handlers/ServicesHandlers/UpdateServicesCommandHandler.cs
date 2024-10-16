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
    public class UpdateServicesCommandHandler : IRequestHandler<UpdateServicesCommand>
    {
        private readonly IRepository<Service> _repository;

        public UpdateServicesCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServicesCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ServiceID);

            values.Description = request.Description;
            values.Title = request.Title;
            values.IconUrl = request.IconUrl;
            
            await _repository.UpdateAsync(values);
        }
    }
}
