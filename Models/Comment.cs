namespace Server.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Created { get; set; }

        //task relation
        public int TaskId { get; set; }
        public TaskItem ? TaskItem { get; set; }

        //user relation
        public int UserId { get; set; }
        public User ? User { get; set; } 


    }
}
