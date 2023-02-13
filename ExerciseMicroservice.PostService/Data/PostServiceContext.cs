using ExerciseMicroservice.PostService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseMicroservice.PostService.Data
{
    public class PostServiceContext : DbContext
    {
        public PostServiceContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<User> User { get; set; }

    }
}
