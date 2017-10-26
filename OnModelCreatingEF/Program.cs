using OnModelCreatingEF.Model;
using OnModelCreatingEF.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnModelCreatingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomAdventureWorksContext context = new CustomAdventureWorksContext())
            {
                DateTime start = DateTime.Now;
                var p1 = context.Person.Take(10);
                Console.WriteLine($"1st query {start - DateTime.Now}");
            }

            using (CustomAdventureWorksContext context = new CustomAdventureWorksContext())
            {
                DateTime start = DateTime.Now;
                var p2 = context.PersonCreditCard.Take(10);
                Console.WriteLine($"2nd query {start - DateTime.Now}");
            }

            using (CustomAdventureWorksContext context = new CustomAdventureWorksContext())
            {
                DateTime start = DateTime.Now;
                var p3 = context.Location.Take(10);
                Console.WriteLine($"3rd query {start - DateTime.Now}");
            }

            using (CustomAdventureWorksContext context = new CustomAdventureWorksContext())
            {
                DateTime start = DateTime.Now;
                var p4 = context.ProductPhoto.Take(10);
                Console.WriteLine($"4th query {start - DateTime.Now}");
            }

            using (CustomAdventureWorksContext context = new CustomAdventureWorksContext())
            {
                DateTime start = DateTime.Now;
                var p5 = context.Illustration.Take(10);
                Console.WriteLine($"5th query {start - DateTime.Now}");
            }
        }
    }
}
