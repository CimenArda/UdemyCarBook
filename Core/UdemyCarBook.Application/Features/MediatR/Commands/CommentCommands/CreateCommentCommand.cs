﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CommentCommands
{
    public class CreateCommentCommand :IRequest
    {
        public string NameSurname { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
        public string Description { get; set; }
    }
}
