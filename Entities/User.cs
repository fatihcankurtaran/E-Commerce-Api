using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [Required]
        public string Role { get; set; }

    }
}