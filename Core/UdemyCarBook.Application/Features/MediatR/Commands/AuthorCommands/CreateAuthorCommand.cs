﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands
{
	public class CreateAuthorCommand :IRequest
	{
		public string AuthorName { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
