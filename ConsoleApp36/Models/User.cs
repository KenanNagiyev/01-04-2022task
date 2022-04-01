using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36.Models
{
    class User:IAccount
    {
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static int _id;
    
        private User()
        {
            ++_id;
            Id = _id;
        }
        public User(string fullname, string password) : this()
        {
            FullName = fullname;
            Password = password;

        }
        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8 && !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                bool isDigit = false;
                bool isUpper = false;
                bool isLawer = false;
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        isLawer = true;
                    }
                    if (isDigit && isLawer && isUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"fullname = {FullName},id:{Id}");
        }

        string IAccount.ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
