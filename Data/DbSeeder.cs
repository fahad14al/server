using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore;
using Server.Models;
namespace Server.Data


{
    public class DbSeeder
    {
        public static async Task SeedAsync(AppDbContext _dbcontext)
        {
            await _dbcontext .Database.MigrateAsync();

            //seed Roles
            if (!_dbcontext.Roles.Any())
            {
                var roles = new List<Role>
                    {
                        new Role { RoleName = "Admin" },
                        new Role { RoleName = "Developer" },
                        new Role { RoleName = "Tester" },
                        new Role { RoleName = "Manager" }
                    };
                _dbcontext.Roles.AddRange(roles);
                await _dbcontext.SaveChangesAsync();

            }

            //seed Users
            if (!_dbcontext.Users.Any())
            {
                var adminRole = await _dbcontext.Roles.FirstOrDefaultAsync(r => r.RoleName == "Admin");
                // create users (remove RoleId usage)
                var users = new[]
                {
                    new User { Username = "admin", UserEmail = "admin@example.com" },
                    new User { Username = "dev1",  UserEmail = "dev1@example.com" },
                    new User { Username = "dev2",  UserEmail = "dev2@example.com" },
                    new User { Username = "Tester", UserEmail = "Tester@example.com" },
                    new User { Username = "Manager", UserEmail = "Manager@example.com" }
                };

                _dbcontext.Users.AddRange(users);
                await _dbcontext.SaveChangesAsync();

                // create user-role links (use RoleId on Role)
                var userRoles = users.Select(u => new UserRole
                {
                    UserId = u.UserId,
                    RoleId = adminRole.RoleId
                }).ToArray();

                _dbcontext.UserRoles.AddRange(userRoles);
                await _dbcontext.SaveChangesAsync();
            }
        }
    }
}
