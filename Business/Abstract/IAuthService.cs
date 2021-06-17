using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {

        User Register(UserForRegisterDto userForRegister);

        User Login(UserForLoginDto userForLoginDto,out bool verification);

        User UserExist(string email);


    }
}
