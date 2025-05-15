using System.ComponentModel.DataAnnotations;

namespace TodoMvcApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Category { get; set; }

        public int Priority { get; set; } // 1-High, 2-Medium, 3-Low

        public bool IsCompleted { get; set; }

        public bool IsHidden { get; set; }
    }
}
