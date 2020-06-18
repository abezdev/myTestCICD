using Microsoft.EntityFrameworkCore;
using myTestCICD.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTestCICD.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        //public DbSet<Account> Accounts { get; set; }
    }
}
