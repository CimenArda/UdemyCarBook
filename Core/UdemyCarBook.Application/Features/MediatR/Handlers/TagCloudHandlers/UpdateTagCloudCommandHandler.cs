﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TagCloudID);
            values.Title= request.Title;
            values.BlogId= request.BlogId;

            await _repository.UpdateAsync(values);
        }
    }
}
