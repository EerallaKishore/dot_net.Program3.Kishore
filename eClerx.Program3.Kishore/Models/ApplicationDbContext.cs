using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eClerx.Program3.Kishore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MVCtest")
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}