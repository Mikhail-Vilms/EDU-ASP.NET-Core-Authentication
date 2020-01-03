using EDU_ASP.NET_Core_Authentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EDU_ASP.NET_Core_Authentication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;

        // this DI takes place because of "services.AddIdentityCore(...)" method is invoked in ConfigureServices method
        public ApplicationUserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("Register")]
        // POST: /api/ApplicationUser/Register
        public async Task<Object> PostApplicationUser(ApplicationUserModel model)
        {
            ApplicationUser applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}