using System.ComponentModel.DataAnnotations;

namespace CRUDApi.Model
{
    public class Register
    { 
        [Required(ErrorMessage ="User Name is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Address is Required")] 
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }

    }
}
