using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.AppUserResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AppUserQueries
{
	public class GetCheckAppUserQuery :IRequest<GetCheckAppUserQueryResult>
	{
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
