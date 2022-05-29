using Microsoft.AspNetCore.Identity;

namespace LaptopStore1.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
