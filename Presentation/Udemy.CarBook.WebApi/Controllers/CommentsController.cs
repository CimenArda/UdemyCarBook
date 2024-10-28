using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace Udemy.CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentRepository;

        public CommentsController(IGenericRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }


        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentRepository.GetAll();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentRepository.GetById(id);
            return Ok(values);
        }

        [HttpPost]  
        public IActionResult CreateComment(Comment comment)
        {
            _commentRepository.Create(comment);
            return Ok("Yorum Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            _commentRepository.Remove(id);
            return Ok("Yorum Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentRepository.Update(comment);
            return Ok("Yorum Başarıyla Güncellendi");
        }

        [HttpGet("GetCommentListByBlogId")]
        public IActionResult GetCommentListByBlogId(int id)
        {
            var value = _commentRepository.GetCommentByBlogId(id);
            return Ok(value);
        }

        

    }
}
