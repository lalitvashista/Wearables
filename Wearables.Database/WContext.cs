using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wearables.Entities;

namespace Wearables.Database
{
    public class WContext :DbContext, IDisposable
    {
        public WContext() : base("WearablesConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
