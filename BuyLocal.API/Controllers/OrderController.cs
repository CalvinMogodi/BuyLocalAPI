using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyLocal.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyLocal.API.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        #region Properties
        /// <summary>
        /// common repository interface
        /// </summary>
        private readonly IOrder _orderRepository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="OrderController"/> class
        /// </summary>
        /// <param name="orderRepository"></param>
        public OrderController(IOrder orderRepository)
        {
            _orderRepository = orderRepository;
        }
        #endregion

        #region Methods

        #endregion
    }
}