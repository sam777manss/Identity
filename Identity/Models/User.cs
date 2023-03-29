using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class User
    {
        //[Required]
        //public string Name { get; set; }

        //[Required]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        //public string Email { get; set; }

        //[Required]
        //public string Password { get; set; }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Enter last name")]
        public string Last_Name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Password { get; set; }

        //  [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number required!")]
        public int Mobile { get; set; }
        public string Gender { get; set; }
        public bool Hobbies_Football { get; set; }
        public bool Hobbies_Dance { get; set; }
        public bool Hobbies_Cricket { get; set; }
    }
}
