namespace Server.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;


        //user can create multiple projects

        public ICollection<Project> Projects { get; set; } = new List<Project>();

        //user can create multiple tasks
        public ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

        //projectmenber relation
        public ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();

        //user can comment on multiple tasks
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        //task assignment relation
        public ICollection<TaskAssignment> TaskAssignments { get; set; } = new List<TaskAssignment>();
    }
}
