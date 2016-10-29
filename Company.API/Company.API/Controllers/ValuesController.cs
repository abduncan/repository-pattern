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
        /// <summary>
        /// Hold our injected instance of the user repository.
        /// </summary>
        private readonly IUserRepository _userRepository;

        public ValuesController(IUserRepository userRepository)
        {
            // Store the injected user repository.
            _userRepository = userRepository;
        }

        public User Get(string email)
        {
            // Use the concrete user repository to retrieve
            // a user by email.
            return _userRepository.GetUserByEmail(email);
        }
    }
}
