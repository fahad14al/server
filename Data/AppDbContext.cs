using Microsoft.EntityFrameworkCore;
namespace Server.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Server.Models.User> Users { get; set; }
        public DbSet<Server.Models.Project> Projects { get; set; }
        public DbSet<Server.Models.TaskItem> TaskItems { get; set; }
        public DbSet<Server.Models.Comment> Comments { get; set; }
        public DbSet<Server.Models.ProjectMember> ProjectMembers { get; set; }
        public DbSet<Server.Models.TaskAssignment> TaskAssignments { get; set; }

    }
}
