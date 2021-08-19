using System;
using System.Net.Mail;

namespace WebApi_JWT.Utils
{
    public static class Validation
    {
        private static int MAX_LENGTH = 25;
        public static bool IsValidEmail (string email)
        {
            try
            {
                if(email.Length > MAX_LENGTH)
                {
                    Console.WriteLine($"Length > max length 25 symbol {email}");
                }
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
