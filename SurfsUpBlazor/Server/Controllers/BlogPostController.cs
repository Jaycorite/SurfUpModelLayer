using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurfsUpBlazor.Server.Data;
using SurfsUpBlazor.Shared.Models;

namespace SurfsUpBlazor.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BlogPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all BlogPosts
        [HttpGet]
        public async Task<List<BlogPost>> Get()
        {
            return await _context.BlogPosts.ToListAsync();
        }

        // Get a BlogPost based on the given ID
        [HttpGet("{id}")]
        public async Task<BlogPost> Get(int id)
        {
            return await _context.BlogPosts.FirstAsync(x => x.Id == id);
        }

        // Posts a BlogPost to the Database (from the DbContext)
        [HttpPost]
        public async Task<BlogPost> Post(BlogPost blogPost)
        {
            var result = await _context.BlogPosts.AddAsync(blogPost);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
