using System.ComponentModel.DataAnnotations;

namespace coreApiC5.Server.DTO
{
    public class loginUserDTO
    {
        [MaxLength(100,ErrorMessage = " the length must be less than 10")]
        [EmailAddress(ErrorMessage = "not email")]
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
