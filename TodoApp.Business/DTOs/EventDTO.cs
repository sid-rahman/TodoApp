using System.ComponentModel.DataAnnotations;

namespace TodoApp.Business.DTOs
{
    public class EventDTO
    {
        [Required]
        public string? Title { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public bool IsAllDay { get; set; }
    }
}
