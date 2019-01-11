using System.ComponentModel.DataAnnotations;

namespace ThumbsUp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 20 charcters")]
        public string Password { get; set; }
    }
}