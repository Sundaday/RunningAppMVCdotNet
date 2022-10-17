using System.ComponentModel.DataAnnotations;

namespace RunningApp.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Email address is required")]
        public string UserName { get; set; } = null!;
        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; } = null!;
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; } = null!;
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}