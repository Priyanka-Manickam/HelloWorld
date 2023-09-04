using System.ComponentModel.DataAnnotations;

namespace CRUDApi.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        public string Password { get; set; }
    }
}
