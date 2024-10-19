using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries
{
	public class GetBlogByIdQuery :IRequest<GetBlogByIdQueryResult>
	{
		public GetBlogByIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
    }
}
