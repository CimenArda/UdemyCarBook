using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Persistance.Context;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;
using UdemyCarBook.Domain.Entities;

namespace Udemy.CarBook.Persistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository :ITagCloudRepository
    {
        private readonly CarBookContext _context;

        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudByBlogId(int id)
        {
            var values= _context.TagClouds.Where(x=> x.BlogId == id).ToList();  
            return values;
        }
    }
}
