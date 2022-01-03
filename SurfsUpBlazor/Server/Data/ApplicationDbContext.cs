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
                new RentalPost(){ Id = 1, Title = "First post", Category = "Surfboard", Price = 100, Deposit = 300, Description = "A nice looking surfboard.", AvailableDateFrom = DateTime.Now, AvailableDateTo = DateTime.Now.Date.AddDays(1), PostedDate = DateTime.Now},
                new RentalPost(){ Id = 2, Title = "2 post", Category = "Paddleboard", Price = 200, Deposit = 200, Description = "I hope it works.", AvailableDateFrom = DateTime.Now, AvailableDateTo = DateTime.Now.Date.AddDays(1), PostedDate = DateTime.Now},
                new RentalPost(){ Id = 3, Title = "3rd post", Category = "Kiteboard", Price = 150, Deposit = 250, Description = "Kiteboard for a nice summer day.", AvailableDateFrom = DateTime.Now.Date.AddDays(10), AvailableDateTo = DateTime.Now.Date.AddDays(15), PostedDate = DateTime.Now },
                new RentalPost(){ Id = 4, Title = "4th post", Category = "Paddleboard", Price = 75, Deposit = 320, Description = "My favorite paddleboard in good condition.", AvailableDateFrom = DateTime.Now.Date.AddDays(7), AvailableDateTo = DateTime.Now.Date.AddDays(11), PostedDate = DateTime.Now },
                new RentalPost(){ Id = 5, Title = "This is a great post", Category = "Kiteboard", Price = 200, Deposit = 400, Description = "This surfboard will give you luck.", AvailableDateFrom = DateTime.Now.Date.AddDays(2), AvailableDateTo = DateTime.Now.Date.AddDays(11), PostedDate = DateTime.Now },
                new RentalPost(){ Id = 6, Title = "Best post", Category = "Surfboard", Price = 100, Deposit = 250, Description = "I hope you will treat this board with care.", AvailableDateFrom = DateTime.Now.Date.AddDays(30), AvailableDateTo = DateTime.Now.Date.AddDays(33), PostedDate = DateTime.Now }
                );
            builder.Entity<BlogPost>().HasData(
                new BlogPost() { Id = 1, Title = "First Blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now },
                new BlogPost() { Id = 2, Title = "2. Blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now.AddDays(2) },
                new BlogPost() { Id = 3, Title = "3rd blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now.AddDays(3) },
                new BlogPost() { Id = 4, Title = "The last Blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now.AddDays(5) },
                new BlogPost() { Id = 5, Title = "Just a Blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now.AddDays(7) },
                new BlogPost() { Id = 6, Title = "My new Blog", Text = "A nice looking surfboard.", PostedDate = DateTime.Now.AddDays(11) }
                );
        }

        public DbSet<RentalPost> RentalPosts { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}