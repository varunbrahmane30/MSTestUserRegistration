using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day20_UserRegistrationProblem
{
    public class RegisterUser
    {

        public static string Regex_MobileNo = "(0|91)?[ ][6-9][0-9]{9}";

        public static bool validateMobileNo(string mobileNo)
        {
            if (Regex.IsMatch(mobileNo, Regex_MobileNo) == true)
                return true;
            else
                return false;
        }
    }
}

