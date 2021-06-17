using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public string  Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int HirePeriod { get; set; }

    }
}
