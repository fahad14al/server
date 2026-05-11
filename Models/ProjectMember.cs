namespace Server.Models
{
    public class ProjectMember
    {
        public int UserId { get; set; }
        public User User { get; set; } = new User();

        public int ProjectId { get; set; }
        public Project Project { get; set; } = new Project();

        public string Role { get; set; } = string.Empty;//Dev/Admin/owner
        public DateTime JoinedDate { get; set; }=new DateTime();
    }
}
