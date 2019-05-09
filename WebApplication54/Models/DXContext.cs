using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication54.Models
{
    public class DXContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }

    }
}