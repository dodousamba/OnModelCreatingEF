using OnModelCreatingEF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnModelCreatingEF.Web.Controllers
{
    public class PersonController : BaseController
    {

        [HttpGet]
        [Route("Person/{businessEntityID}")]
        public async Task<Person> Get(long businessEntityID)
        {
            return await this.ServiceFactory.PersonManager.Get(businessEntityID);
        }
    }
}
