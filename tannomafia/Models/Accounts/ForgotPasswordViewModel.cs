using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
