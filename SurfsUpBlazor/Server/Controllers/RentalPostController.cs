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
    public class RentalPostController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RentalPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all RentalPosts
        [HttpGet]
        public async Task<List<RentalPost>> Get()
        {
            return await _context.RentalPosts.ToListAsync();
        }

        // Get a RentalPost based on the given ID
        [HttpGet("{id}")]
        public async Task<RentalPost> Get(int id)
        {
            return await _context.RentalPosts.FirstAsync(x => x.Id == id);
        }

        // Posts a RentalPost to the Database (from the DbContext)
        [HttpPost]
        public async Task<RentalPost> Post(RentalPost rentalPost)
        {
            var result = await _context.RentalPosts.AddAsync(rentalPost);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
