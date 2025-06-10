using BranchPortal.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BranchPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }
    }
}
