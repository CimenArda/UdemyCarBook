using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAllBlogWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthor();
            return values.Select(x => new GetAllBlogWithAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                CategoryName=x.Category.Name,
                AuthorName = x.Author.AuthorName,
                BlogId = x.BlogId,
                Description=x.Description,  
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title
            }).ToList();
        }
    }
}
