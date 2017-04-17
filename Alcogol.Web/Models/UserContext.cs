using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Alcogol.Web.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("Alcogol")
        { }

        public DbSet<User> Users { get; set; }
    }
}