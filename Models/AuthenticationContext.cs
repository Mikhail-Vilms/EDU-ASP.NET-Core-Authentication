using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EDU_ASP.NET_Core_Authentication.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        // DbContextOptions will be injected automatically since we added 
        // "services.AddDbContext<AuthenticationContext" in "ConfigureServices" method 
        public AuthenticationContext(DbContextOptions options) : base(options)
        {
        } 
    }
}
