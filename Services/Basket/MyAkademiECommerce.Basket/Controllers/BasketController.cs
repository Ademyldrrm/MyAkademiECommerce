using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAkademiECommerce.Basket.LoginServices;

namespace MyAkademiECommerce.Basket.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public BasketController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpGet]
        public async Task<IActionResult> GetUserInfo()
        {
            var user = User.Claims;
            return Ok("Kullanıcı Geldi");
        }
    }
}
