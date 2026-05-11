namespace Server.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string ProjectDescription { get; set; } = string.Empty;

        // user can create project
        public int CreatorId { get; set; } 

        public User Creator { get; set; } = new User();

        //tasks relation
        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

        //projectmenber relation
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();
    }
}
