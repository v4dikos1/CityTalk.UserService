using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public string Test()
        {
            return "Авторизован";
        }
    }
}
