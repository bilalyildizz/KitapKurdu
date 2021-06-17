using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var user = _authService.UserExist(userForRegisterDto.Email);
            if (user != null)
            {
                return BadRequest("Kullanıcı Mevcut");
            }

            var regisretResult = _authService.Register(userForRegisterDto);
            if(regisretResult != null)
            {
                return Ok(regisretResult);
            }

            return BadRequest("Kayıt Başarısız");

        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            bool verification;
            var user = _authService.Login(userForLoginDto, out verification);
            if (!verification)
            {
                return BadRequest("Kullanıcı Adı veya Şifre Hatalı");
            }

            return Ok(user);

        }

     

    }
}
