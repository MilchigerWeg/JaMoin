using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JaMoin.Models;
using JaMoin.Data;

namespace JaMoin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Uebersicht()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("~/Identity/Account/Login");
            }

            var uebersichtModel = new UebersichtViewModel();

            //Allen Usern ihre Schulden zuweisen
            var allUsers = _context.GetAllUsernames();
            uebersichtModel.AllUsers = new List<UserDebtModel>();

            foreach(var user in allUsers) 
            {
                var userItem = new UserDebtModel()
                {
                    Username = user,
                    Debt = _context.GetSchuldenSummeZuUser(user)
                };

                uebersichtModel.AllUsers.Add(userItem);   
            }
            //Gesamt-geliehener Betrag errechnen
            uebersichtModel.GesamtgeliehenerBetrag = _context.GetGesamtGeliehenBetrag();
            //Alle Transaktionen holen
            uebersichtModel.AllTransactions = _context.GetAllTransactions();

            return View("Uebersicht", uebersichtModel);
        }

        public IActionResult CreateTransaction()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("~/Identity/Account/Login");
            }

            var viewModel = new TransactionCreateViewModel();

            viewModel.AllUsernames = _context.GetAllUsernames(); ;

            return View("CreateTransaction", viewModel);
        }

    }
}
