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

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

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

            //var emptyModel = new List<TransactionModel>();
            //emptyModel.Add(new TransactionModel()
            //{
            //    GeldgeberEmail = "123@mail.de",
            //    GesamtBetrag = 12.12,
            //    Kommentar = "testüberweisung",
            //    Schulden = new List<SchuldenModel>()
            //    {
            //        new SchuldenModel()
            //        {
            //            Betrag = 12.12,
            //            SchuldnerEmail = "schulden@mail.de"
            //        }
            //    }
            //});

            var x = _context;
            //_dbContext.Add(emptyModel.First());

            return View(emptyModel);
        }

        public IActionResult CreateTransaction()
        {
            return View("CreateTransaction");
        }

    }
}
