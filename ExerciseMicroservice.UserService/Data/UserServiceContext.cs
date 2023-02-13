using ExerciseMicroservice.UserService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseMicroservice.UserService.Data
{
    public class UserServiceContext:DbContext
    {
        public UserServiceContext(DbContextOptions<UserServiceContext> options) :base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
