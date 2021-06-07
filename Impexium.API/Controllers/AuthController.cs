using Impexium.API.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impexium.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class AuthController : ControllerBase
    {

        readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthRequest request)
        {
            AuthResponse response = null;

            await Task.Run(() =>
            {
                response = _authService.Auth(request);
            });

            if (response == null)
            {
                response = new AuthResponse
                {
                    Message = "The user name or password is not correct.",
                    Status = System.Net.HttpStatusCode.BadRequest
                };
                return BadRequest(response);
            }

            response.Status = System.Net.HttpStatusCode.OK;

            return Ok(response);
        }


    }
}
