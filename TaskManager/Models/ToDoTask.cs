namespace TaskManager.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
