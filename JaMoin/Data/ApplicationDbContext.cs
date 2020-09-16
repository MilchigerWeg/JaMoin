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
            return this.Users.Where(u => u.EmailConfirmed).Select(u => u.Email).OrderBy(u => u).ToList();
        }

        public List<TransactionModel> GetAllTransactions()
        {
            //gibt alle Confirmeden usernamen zurück
            return this.Transactions.Include(t => t.Schulden).ToList();
        }

        public double GetSchuldenSummeZuUser(string username)
        {
            var allTransactions = GetAllTransactions();
            //Alle Schulden zu einer Person lesen
            var allSchulden = allTransactions.Select(t => t.Schulden).Where(t => t.Any(s => s.SchuldnerEmail == username)).ToList();
            //Alles, was eine Person geliehen hat
            var allGeliehen = allTransactions.Where(t => t.GeldgeberEmail == username).Select(t => t.GesamtBetrag);

            //Schulden aufsummieren
            double gesamtschuld = 0.0;
            foreach (var schuld in allSchulden)
            {
                gesamtschuld += schuld.First().Betrag;
            }

            //geliehenes aufsummieren
            double gesamtgeliehen = 0.0;
            foreach (var leihgabe in allGeliehen)
            {
                gesamtgeliehen += leihgabe;
            }

            //differenz
            return gesamtgeliehen - gesamtschuld;
        }

        public double GetGesamtGeliehenBetrag()
        {
            return GetAllTransactions().Select(t => t.GesamtBetrag).Sum();            
        }
    }
}
