using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace HRManagementSystem.Helpers
{
    public static class PasswordHelper
    {
        private static readonly PasswordHasher<object> Hasher = new();

        public static string HashPassword(string password)
        {
            return Hasher.HashPassword(null!, password);
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            var result = Hasher.VerifyHashedPassword(
                null!,
                passwordHash,
                password);

            return result == PasswordVerificationResult.Success ||
                   result == PasswordVerificationResult.SuccessRehashNeeded;
        }
    }
}
