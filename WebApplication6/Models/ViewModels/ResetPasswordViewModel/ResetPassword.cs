using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer.Models.ViewModels.ResetPasswordViewModel
{
    public class ResetPassword
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Is Required")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
