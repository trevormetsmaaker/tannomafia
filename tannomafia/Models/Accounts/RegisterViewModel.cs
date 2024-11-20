using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "confirm your password by typing again")]
        [Compare("password", ErrorMessage = Password and)]
        public string ConfrimPassword { get; set; }
        public string City { get; set; }
    }
}
