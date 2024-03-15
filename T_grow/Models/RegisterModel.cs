using System.ComponentModel.DataAnnotations;

namespace T_grow.Models
{
    public class RegisterModel
    {
        [Required,StringLength(100)]
        public string UserName { get; set; }
        [Required, StringLength(250)]

        public string Email { get; set; }
        [Required, StringLength(128)]

        public string Password { get; set; }
        [Required, StringLength(128)]


        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
