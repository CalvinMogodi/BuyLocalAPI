using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyLocal.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuyLocal.API.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Properties
        /// <summary>
        /// common repository interface
        /// </summary>
        private readonly IProduct _productRepository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instanace of the <see cref="ProductController"/> class
        /// </summary>
        /// <param name="productRepository"></param>
        public ProductController(IProduct productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        #region Methods

        #endregion
    }
}