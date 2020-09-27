using Microsoft.AspNetCore.Identity;

namespace jwtapi
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}