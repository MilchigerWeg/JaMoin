using JaMoin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace JaMoin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<TransactionModel> Transactions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {            
        }

    }
}
