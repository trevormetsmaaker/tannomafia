using System.ComponentModel.DataAnnotations;

namespace tannomafia.Models.Accounts
{
    public class LoginViewModelcs
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display( Name = "remeber this account")]
        public bool RemeberMe { get; set; }
        public string? ReturnURL { get; set; }
    }
}
