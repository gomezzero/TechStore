using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Utils
{
    public class PasswordHasher
    {

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
        }
    }
}