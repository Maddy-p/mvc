using System.ComponentModel.DataAnnotations;
namespace MVCLoginRegistration.Models
{
    public class Useraccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression (@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"+ @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"+ @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="Enter the valid parameter")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get; set; }
    }
}