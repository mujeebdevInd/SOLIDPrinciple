using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class UserService
    {
        private readonly ILogger _logger;
        public UserService(ILogger logger)
        {
            _logger = logger;
        }
        public void RegisterUser(string username)
        {
            // Code to register user
            _logger.Log("User registered: " + username);
        }
    }
}
