using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    public class Event
    {
        [Key]
        public Guid EventId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        
        [ForeignKey(nameof(User))]
        public Guid CreatedBy{ get; set; }
    }
}