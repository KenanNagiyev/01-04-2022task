using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36.Models
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public string ShowInfo();
    }
}
