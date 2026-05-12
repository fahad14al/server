namespace Server.Models
{
    public class ProjectMember
    {
        public int UserId { get; set; }
        public User ? User { get; set; } 

        public int ProjectId { get; set; }
        public Project ? Project { get; set; } 

        public string Role { get; set; } = string.Empty;//Dev/Admin/owner
        public DateTime JoinedDate { get; set; } = DateTime.UtcNow;
    }
}
