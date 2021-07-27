using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationProblem
{
    public class RegisterUser
    {
        public static String Regex_Name = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";

        public bool validateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_Name) == true)
                return true;
            else
                return false;
        }
    }
}

