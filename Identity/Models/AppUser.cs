using Microsoft.AspNetCore.Identity;

namespace Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string Last_Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public int Mobile { get; set; }
        public string Gender { get; set; }
        public bool Hobbies_Football { get; set; }
        public bool Hobbies_Dance { get; set; }
        public bool Hobbies_Cricket { get; set; }
    }
}
