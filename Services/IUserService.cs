using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_JWT.Entities;
using WebApi_JWT.Models;

namespace WebApi_JWT.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<AuthenticateResponse> Register(UserModel userModel);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        User DeleteById(Guid id);
    }
}
