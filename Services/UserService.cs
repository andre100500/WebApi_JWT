using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_JWT.Entities;
using WebApi_JWT.Helpers;
using WebApi_JWT.Models;
using WebApi_JWT.Utils;

namespace WebApi_JWT.Services
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<User> _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly UserDBContext db;
        //private readonly ILogger _logger;

        public UserService(IEfRepository<User> userRepository, IConfiguration configuration, IMapper mapper, UserDBContext context/*ILogger logger*/)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _mapper = mapper;
            db = context;
            //_logger = logger;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _userRepository.GetAll().FirstOrDefault(x => x.Name == model.Name && x.Password == model.Password);

            if(user == null)
            {
                //_logger.LogError("Incorect data", user);
                return null;
            }
            var token = _configuration.GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public User DeleteById(Guid id)
        {
            return _userRepository.DeleteById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public async Task<AuthenticateResponse> Register(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);

            var addUser = await _userRepository.Add(user);

            var response = Authenticate(new AuthenticateRequest
            {
                Name = user.Name,
                Password = user.Password
            });

            return response;
        }
    }
}
