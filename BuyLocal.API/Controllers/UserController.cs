using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BuyLocal.BusinessLayer.Interfaces;
using BuyLocal.BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BuyLocal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Properties
        /// <summary>
        /// common repository interface
        /// </summary>
        private readonly IUser _userRepository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="ProductController"/> class
        /// </summary>
        /// <param name="commonRepository"></param>
        public UserController(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region Methods
        [HttpGet]
        public string Login(string password, string username)
        {
            BuyLocalRespond respond = _userRepository.Login(password, username);
            return JsonConvert.SerializeObject(respond);
        }

        [HttpPost]
        public string RegisterUser([FromBody]User user)
        {
            BuyLocalRespond respond = _userRepository.CreateUser(user);
            return JsonConvert.SerializeObject(user);
        }

        #endregion

    }
}
