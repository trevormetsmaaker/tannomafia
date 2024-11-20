using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class AddPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "type new password here:")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "type it again to confirm")]
        [Compare("NewPassword", ErrorMessage = "The new password and its confirmation do not match. Please retry.")]
        public string ConfirmPassword { get; set;}
    }
}
