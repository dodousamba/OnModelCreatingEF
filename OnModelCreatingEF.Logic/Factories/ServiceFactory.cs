using OnModelCreatingEF.Logic.Manager;
using OnModelCreatingEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF.Logic.Factories
{
    public abstract class ServiceFactory
    {
        public CustomAdventureWorksContext Context { get; protected set; }

        public PersonManager PersonManager
        {
            get
            {
                return new PersonManager(this);
            }
        }
    }
}
