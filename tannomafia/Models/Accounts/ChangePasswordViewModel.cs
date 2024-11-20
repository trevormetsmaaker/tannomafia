using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display (Name = "type your current password")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "type your new password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = " type it again to confirm")]
        public string ConfirmPassword { get; set;}
    }
}
