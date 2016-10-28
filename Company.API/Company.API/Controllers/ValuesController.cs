using Company.Domain.Repository.GenericRepository;
using Company.Domain.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Company.API.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IUserRepository _userRepository;

        public ValuesController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }
    }
}
