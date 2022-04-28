using System.Threading.Tasks;
using CleanArchitecture.Application.Dtos.User;
using CleanArchitecture.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService accountService)
        {
            _userService = accountService;
        }
        [HttpPost("auth")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await _userService.AuthenticateAsync(request));
        }
    }
}
