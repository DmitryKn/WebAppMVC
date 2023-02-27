using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Contact
    {
        [Display(Name="First name")]
        [Required(ErrorMessage = "Inter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Inter your lastname")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Inter your Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Inter your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inter your Message")]
        [MinLength(10, ErrorMessage = "The message should be not less then 10 letters.")]
        public string Message { get; set; }
    }
}
