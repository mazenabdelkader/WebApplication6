using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer.Models.ViewModels.ForgetPasswordViewModel
{
    public class ForgertPassword
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get; set; } = null!;
    }
}
