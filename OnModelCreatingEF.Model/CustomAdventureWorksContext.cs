using Microsoft.EntityFrameworkCore;
using OnModelCreatingEF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF.Model
{
    public class CustomAdventureWorksContext : AdventureWorksContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
