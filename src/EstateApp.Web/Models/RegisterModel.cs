using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateApp.Web.Models
{
    public class RegisterModel
    {
        [DisplayName("Name")]
        [Required]
        public string FullName { get; set; }

        [DisplayName("Email Address")]
        [Required]
        [EmailAddress] //server side validation.
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}