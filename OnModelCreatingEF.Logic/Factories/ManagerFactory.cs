using OnModelCreatingEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF.Logic.Factories
{
    public class ManagerFactory : ServiceFactory
    {
        public ManagerFactory()
        {
            this.Context = new CustomAdventureWorksContext();
        }
    }
}
