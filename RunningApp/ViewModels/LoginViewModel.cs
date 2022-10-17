using System.ComponentModel.DataAnnotations;

namespace RunningApp.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "EmailAddress")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
