using System;
using System.Windows.Forms;

namespace PasswordManager
{
    class PasswordGenerator
    {
        private static readonly Random _getRandom = new Random();
        private static readonly object _syncLock = new object();

        private static readonly int _specialCharactersCount = 19;
        private static readonly int _letterCount = 26;
        private static readonly int _numbercount = 10;

        private static readonly string[] _specialCharacters = {
            "@", "~", "/", "+", "-", "*", "(", "=",
            "%", "&", "$", "£", ")", "{", "}", "!", ".", ",", "?"};
        private static readonly string[] _letters = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y", "z" };
        private static readonly string[] _number =
        {
            "0","1", "2", "3", "4", "5", "6", "7", "8", "9"
        };

        public PasswordGenerator()
        {
            //Empthy constructor
        }

        public int GetRandomNumber(int min, int max)
        {
            lock (_syncLock)
            { // synchronize
                return _getRandom.Next(min, max);
            }
        }

        public string GenPassword(int length, Boolean numbers, Boolean specialChars)
        {
            string password = "";
            int iterations = 0;

            if (length<=0)
            {
                throw new InvalidPasswordException();
            }
            else
            {
                while (password.Length < length)
                {
                    if (GetRandomNumber(0, 9) < 4)
                    {
                        if (GetRandomNumber(0, 9) < 4)
                        {
                            password += _letters[_getRandom.Next(0, _letterCount)];
                        }
                        else
                        {
                            password += _letters[_getRandom.Next(0, _letterCount)].ToUpper();
                        }
                    }
                    if (numbers && GetRandomNumber(0, 9) < 4)
                    {
                        password += _number[_getRandom.Next(0, _numbercount)];
                    }
                    if (specialChars && GetRandomNumber(0, 9) < 2)
                    {
                        password += _specialCharacters[_getRandom.Next(0, _specialCharactersCount)];
                    }
                    iterations++;
                }
            }

            return password;
        }

    }
}
