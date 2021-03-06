using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jwtapi
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecuredController : ControllerBase
    {
        [HttpGet]
        // public async Task<IActionResult> GetSecuredData()
        public IActionResult GetSecuredData()
        {
            return Ok("This Secured Data is available only for Authenticated Users.");
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult PostSecuredData()
        {
            return Ok("This Secured Data is available only for Administrator Users.");
        }
    }
}