using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationProblem
{
    public class RegisterUser
    {

        public static string Regex_Password = "[A-Z][a-zA-Z0-9!@#$%^&*~]{7}[a-zA-Z0-9]*";

        public static bool validatePassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == true)
                return true;
            else
                return false;
        }
    }
}

