namespace MT.CoE.UserManagement.Models
{
    public class Task
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public int TaskType { get; set; }
    }

    public class TaskType
    {
        public string Type { get; set; }
        public int Id { get; set; }
    }
}