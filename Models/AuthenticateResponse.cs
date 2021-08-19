using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_JWT.Entities;

namespace WebApi_JWT.Models
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Surname = user.Surname;
            Email = user.Email;
            Token = token;
        }
    }
}
