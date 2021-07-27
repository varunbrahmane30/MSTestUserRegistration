using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationProblem
{
    public class RegisterUser
    {
       
        public static string Regex_lName = "^[A-Z]{1}[A-Za-z]{1}[a-zA-Z]*$";
       
        public static bool validateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, Regex_lName) == true)
                return true;
            else
                return false;
        }
    }
}

