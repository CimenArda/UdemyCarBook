﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands
{
    public class CreateTagCloudCommand :IRequest
    {
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}
