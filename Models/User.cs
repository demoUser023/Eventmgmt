using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Column(TypeName = "varchar(20)")]
        public Role Role { get; set; }
    }
     public enum Role
        {
            Student,Admin
        }
}