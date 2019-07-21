using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPDV.model;
using Microsoft.EntityFrameworkCore;
namespace apiPDV.database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Change> Changes { get; set; }

    }
}

