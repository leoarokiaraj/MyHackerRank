using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            int PasswordMinNumber = 2;
            int PasswordMinLowerCase = 2;
            int PasswordMinUpperCase = 2;
            int PasswordMinSpecialChar = 3;
            int MinLength = 8;
            int MaxLenth = 22;

            System.Text.StringBuilder regex = new System.Text.StringBuilder();
            string regexPrefix = "^";
            string positiveLookAhead = "(?=";
            string NumberRegex = @".*\d)";
            string LowerCaseRegex = ".*[a-z])";
            string UpperCaseRegex = ".*[A-Z])";
            string SpecialCharacterRegex = ".*[!@#$%^&*\\-_=+ ;:,.?'\"/\\|()[\\]{}<>`~])";
            string regexSuffix = "$";

            regex.Append(regexPrefix);
            if (PasswordMinNumber > 0)
            {
                if (PasswordMinNumber > 1)
                    NumberRegex = positiveLookAhead + "(" + NumberRegex + "{" + PasswordMinNumber + "})";
                else
                    NumberRegex = positiveLookAhead + NumberRegex;
                regex.Append(NumberRegex);
            }
            if (PasswordMinLowerCase > 0)
            {
                if (PasswordMinLowerCase > 1)
                    LowerCaseRegex = positiveLookAhead + "(" + LowerCaseRegex + "{" + PasswordMinNumber + "})";
                else
                    LowerCaseRegex = positiveLookAhead + LowerCaseRegex;
                regex.Append(LowerCaseRegex);
            }
            if (PasswordMinUpperCase > 0)
            {
                if (PasswordMinUpperCase > 1)
                    UpperCaseRegex = positiveLookAhead + "(" + UpperCaseRegex + "{" + PasswordMinNumber + "})";
                else
                    UpperCaseRegex = positiveLookAhead + UpperCaseRegex;
                regex.Append(UpperCaseRegex);
            }
            if (PasswordMinSpecialChar > 0)
            {
                if (PasswordMinSpecialChar > 1)
                    SpecialCharacterRegex = positiveLookAhead + "(" + SpecialCharacterRegex + "{" + PasswordMinNumber + "})";
                else
                    SpecialCharacterRegex = positiveLookAhead + SpecialCharacterRegex;
                regex.Append(SpecialCharacterRegex);
            }
            regex.Append(".{" + MinLength + "," + MaxLenth + "}");
            regex.Append(regexSuffix);
            string ret = regex.ToString();
        }
    }
}
