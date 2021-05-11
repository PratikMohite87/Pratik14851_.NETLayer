using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAssignment
{
    class ValidationClass
    {
        private int count;

        public ValidationClass()
        {
            count = 0;
        }

        public static bool NoOfCharacters(string password)
        {
            return password.Length >= 5;
        }

        public static bool OneCapitalLetter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (Char.IsUpper(ch))
                    return true;
                else
                    continue;
            }

            return false;
        }

        public static bool HaveDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (Char.IsDigit(ch))
                    return true;
                else
                    continue;
            }

            return false;
        }

        public static bool HaveSpecialCharacter(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (!Char.IsLetterOrDigit(ch))
                    return true;
                else
                    continue;
            }

            return false;
        }

        public int PasswordStrength(string password)
        {
            if (ValidationClass.NoOfCharacters(password))
                count++;
            else
                return 0;

            if (ValidationClass.HaveDigit(password))
                count++;

            if (ValidationClass.HaveSpecialCharacter(password))
                count++;

            if (ValidationClass.OneCapitalLetter(password))
                count++;

            return count;
        }
    }
}
