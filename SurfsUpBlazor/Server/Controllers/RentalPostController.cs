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
    public class RentalPostController
    {
        private readonly ApplicationDbContext _context;
        public RentalPostController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<RentalPost>> Get()
        {
            return await _context.RentalPosts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<RentalPost> Get(int id)
        {
            return await _context.RentalPosts.FirstAsync<RentalPost>(x => x.Id == id);
        }
    }
}
