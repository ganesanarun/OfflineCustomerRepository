using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FERN_OFFLINE_SAMPLE_APP.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("Customers")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}