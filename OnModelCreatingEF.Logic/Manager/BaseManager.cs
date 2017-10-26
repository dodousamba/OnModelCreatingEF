using OnModelCreatingEF.Logic.Factories;
using OnModelCreatingEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF.Logic.Manager
{
    public class BaseManager
    {

        protected readonly CustomAdventureWorksContext Context;

        public BaseManager(ServiceFactory serviceFactory)
        {
            this.Context = serviceFactory.Context;            
        }
    }
}
