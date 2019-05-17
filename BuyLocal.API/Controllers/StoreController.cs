using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyLocal.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyLocal.API.Controllers
{
    [Route("api/Store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        #region Properties
        /// <summary>
        /// common repository interface
        /// </summary>
        private readonly IStore _storeRepository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="StoreController"/> class
        /// </summary>
        /// <param name="storeRepository"></param>
        public StoreController(IStore storeRepository)
        {
            _storeRepository = storeRepository;
        }
        #endregion

        #region Methods

        #endregion
    }
}