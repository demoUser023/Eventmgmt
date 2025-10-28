using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EventManagement.Models
{
    public class Registration
    {
        [Key]
        public Guid RegistrationId { get; set; }

        
        public Event Event { get; set; }
        public Guid EvenId { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}