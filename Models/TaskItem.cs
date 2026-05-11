namespace Server.Models
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = string.Empty;

        // ownership
        public int CreatorId { get; set; }
        public User Creator { get; set; } = new User();

        //project Relation
        public int ProjectId { get; set; }
        public Project Project { get; set; } = new Project();

        //task assignment relation
        public ICollection<TaskAssignment> TaskAssignments { get; set; } = new List<TaskAssignment>();
    }
}
