using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationProblem
{
    public class RegisterUser
    {
        public static string Regex_Password = "^*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";

        public static bool validatePassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == true)
                return true;
            else
                return false;
        }
    }
}

