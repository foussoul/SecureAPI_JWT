using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureAPI_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet("user")]
        public IActionResult GetForUser()
        {
            return Ok("Hello, vous êtes connecté (token valide).");
        }

        [Authorize(Roles = "admin")]
        [HttpGet("admin")]
        public IActionResult GetForAdmin()
        {
            return Ok("Hello Admin, vous avez le droit d'accéder ici.");
        }
    }
}