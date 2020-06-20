using Microsoft.AspNetCore.Identity;

namespace EstateApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}