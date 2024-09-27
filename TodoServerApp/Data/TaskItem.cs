using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime? CreatedData { get; set; }
        public DateTime? FinishData { get; set; }
    }
}
