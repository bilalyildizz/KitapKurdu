using Business.Abstract;
using Core.Utilities.Security;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;

        }
        public User Login(UserForLoginDto userForLoginDto, out bool verification)
        {
            
            var user = _userService.GetByEmail(userForLoginDto.Email);
            if (user == null)
            {
                verification= false;
                return user;
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, user.Password,user.PasswordSalt))
            {
                verification = false;
                return user;

            }
            verification = true;
            return user;


        }

        public User Register(UserForRegisterDto userForRegister)
        {
            byte[] passwordHash,passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegister.Password, out passwordHash,out passwordSalt);
            User user = new User
            {
                Name = userForRegister.Name,
                Surname = userForRegister.Surname,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                RegistrationDate=DateTime.Now,
                HirePeriod =15,
                Email=userForRegister.Email
                

            };
            _userService.Add(user);

            return user;

        }

        public User UserExist(string email)
        {
            return _userService.GetByEmail(email);
        }
    }
}
