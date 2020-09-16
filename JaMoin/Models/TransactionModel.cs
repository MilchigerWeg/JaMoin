using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaMoin.Models
{
    public class TransactionModel
    {
        public string Kommentar { get; set; }
        public double GesamtBetrag { get; set; }
        public string GeldgeberEmail { get; set; }
        public List<SchuldenModel> Schulden { get; set; }

    }
}
