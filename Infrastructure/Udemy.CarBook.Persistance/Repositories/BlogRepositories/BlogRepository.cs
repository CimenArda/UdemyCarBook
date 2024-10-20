using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Persistance.Context;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Domain.Entities;

namespace Udemy.CarBook.Persistance.Repositories.BlogRepositories
{
	public class BlogRepository : IBlogRepository
	{
		private readonly CarBookContext _context;

		public BlogRepository(CarBookContext context)
		{
			_context = context;
		}

        public List<Blog> GetAllBlogsWithAuthor()
        {
			var values = _context.Blogs.Include(x => x.Author).Include(y=>y.Category).ToList();
			return values;

        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _context.Blogs.Include(x=>x.Author).Where(y=>y.BlogId== id).ToList();
			return values;
        }

        public List<Blog> GetLast3BlogsWithAuthor()
		{
			var values = _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
			return values;
		}
	}
}
