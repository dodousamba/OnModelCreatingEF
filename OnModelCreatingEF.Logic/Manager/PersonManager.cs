using OnModelCreatingEF.Logic.Factories;
using OnModelCreatingEF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF.Logic.Manager
{
    public class PersonManager : BaseManager
    {
        public PersonManager(ServiceFactory serviceFactory)
            : base(serviceFactory)
        {
        }

        public async Task<Person> Get(long businessEntityID)
        {
            return await Task.Run(() =>
            {
                return this.Context.Person.Where(o => o.BusinessEntityId == businessEntityID).First();
            });
        }
        
    }
}
