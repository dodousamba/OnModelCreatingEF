using OnModelCreatingEF.Logic.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnModelCreatingEF.Web.Controllers
{
    public class BaseController: ApiController
    {
        /// <summary>
        /// Gets or sets the entity framework Context.
        /// </summary>
        /// <value>
        /// The entity framework Context.
        /// </value>
        private ServiceFactory _ServiceFactory;
        protected ServiceFactory ServiceFactory
        {
            get
            {
                if(_ServiceFactory == null)
                {
                    _ServiceFactory = new ManagerFactory();
                }

                return _ServiceFactory;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        /// <param name="serviceFactory">The service factory.</param>
        public BaseController(ServiceFactory serviceFactory)
        {
            if (serviceFactory == null)
            {
                return;
            }
        }

        public BaseController()
        {
        }
    }
}