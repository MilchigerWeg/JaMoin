using JaMoin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
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

        public List<string> GetAllUsernames()
        {
            //gibt alle Confirmeden usernamen zurück
            return this.Users.Where(u => u.EmailConfirmed).Select(u => u.Email).ToList();
        }

        public List<TransactionModel> GetAllTransactions()
        {
            //gibt alle Confirmeden usernamen zurück
            return this.Transactions.Include(t => t.Schulden).ToList();
        }
    }
}
