using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public enum Priority
    {
        Low,
        Medium,
        High,
    }

    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        public Priority Priority { get; set; }

        [DisplayName("Is Completed")]
        public bool IsCompleted { get; set; }
    }
}
