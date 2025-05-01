using System.ComponentModel.DataAnnotations;

namespace Presentation_Layer.Models.ViewModels.RegisterViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First Name Required")]
        [MaxLength(50)]
        public String FirstName { get; set; } = null!;
        ////////////
        [Required]
        [MaxLength(50)]
        public String LastName { get; set; }

        /////////

        [Required]
        [MaxLength(50)]
        public String UserName { get; set; }

        ///////
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        ///////
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /////
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        ////
        public bool IsAgree { get; set; }

    }
}
