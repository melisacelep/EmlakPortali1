using Microsoft.AspNetCore.Identity;

namespace EmlakPortali1.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string PhotoUrl { get; set; }
    }
}
