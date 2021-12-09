using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SurfsUpBlazor.Server.Models;
using SurfsUpBlazor.Shared.Models;

namespace SurfsUpBlazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RentalPost>().HasData(
                new RentalPost(){ Id = 1, Title = "First post", Category = "Surfboard", Price = 100, Deposit = 300, Description = "A nice looking surfboard", AvailableDateFrom = DateTime.Now, AvailableDateTo = DateTime.Now.Date.AddDays(1), PostedDate = DateTime.Now},
                new RentalPost(){ Id = 2, Title = "2 post", Category = "Paddleboard", Price = 200, Deposit = 200, Description = "I hope it works", AvailableDateFrom = DateTime.Now, AvailableDateTo = DateTime.Now.Date.AddDays(1), PostedDate = DateTime.Now}
                );
        }

        public DbSet<RentalPost> RentalPosts { get; set; }
    }
}