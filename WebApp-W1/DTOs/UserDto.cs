using System.ComponentModel.DataAnnotations;

namespace WebApp_W1.DTOs
{
    public class UserDto
    {
        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(10, ErrorMessage = "Name must be at most 10 characters.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Surname field is required.")]
        public string Surname { get; set; } = null!;

        [Required(ErrorMessage = "Name field is required.")]
        [Range(18, 64, ErrorMessage = "The Age range should be between 18-64.")]
        public short Age { get; set; }

    }
}
