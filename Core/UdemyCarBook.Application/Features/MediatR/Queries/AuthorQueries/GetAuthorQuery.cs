using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries
{
	public class GetAuthorQuery: IRequest<List<GetAuthorQueryResult>>
	{
	}
}
