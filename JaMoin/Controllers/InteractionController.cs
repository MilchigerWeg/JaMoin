using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using JaMoin.Data;
using JaMoin.Models;
using Microsoft.AspNetCore.Mvc;

namespace JaMoin.Controllers
{
    public class InteractionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InteractionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult CreateNewTransaction([FromBody]TransactionCreateModel transaction)
        {
            var gesamtbetrag = Convert.ToDouble(transaction.GesamterBetrag, new CultureInfo("en-US"));

            if(gesamtbetrag <= 0)
            {
                return StatusCode(406);
            }

            if(transaction.GeldEmpfaenger == transaction.GeldLeiher)
            {
                return StatusCode(409);
            }

            var newTransModel = new TransactionModel()
            {
                Kommentar = transaction.Kommentar,
                GesamtBetrag = gesamtbetrag,
                GeldgeberEmail = transaction.GeldLeiher,
                Schulden = new List<SchuldenModel>()
                {
                    new SchuldenModel()
                    {
                        Betrag = gesamtbetrag,
                        SchuldnerEmail = transaction.GeldEmpfaenger
                    }
                }
            };

            _context.Transactions.Add(newTransModel);

            _context.SaveChanges();
            return StatusCode(200);
        }
    }
}