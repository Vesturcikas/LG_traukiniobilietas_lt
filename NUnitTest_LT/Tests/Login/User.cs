using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Tests.Login
{
    public class User
    {
        public static User DefaultUser = new User("vestas1976@gmail.com", "neteisingas");

        public string Useremail;
        public string Password;

        public User(string useremail, string password)
        {
            Useremail = useremail;
            Password = password;
        }
    }
}
