using FileAPILesson.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileAPILesson.Data
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<ProfileTeacher> Teachers { get; set; }
    }
}
