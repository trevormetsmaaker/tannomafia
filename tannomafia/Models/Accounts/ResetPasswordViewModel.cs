using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "confirm you password by typing it again")]
        [Compare("password", ErrorMessage = "Password and its confirmation do not match please try again")]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }

    }
}
