using ExerciseMicroservice.PostService.Data;
using ExerciseMicroservice.PostService.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExerciseMicroservice.PostService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostServiceContext _context;

        public PostController(PostServiceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPost()
        {
            return await _context.Post.Include(x=>x.User).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Post>> Post([FromBody] Post post)
        {
            _context.Post.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = post.PostId });
        }
    }
}
