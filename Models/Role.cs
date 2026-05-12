namespace Server.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;

        //user role relation
        public ICollection<UserRole> ? UserRoles { get; set; }
    }
}
