using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaMoin.Models
{
    public class TransactionCreateModel
    {
        public string Kommentar { get; set; }
        public string GesamterBetrag { get; set; }
        public string GeldLeiher {get;set;}
        public string GeldEmpfaenger { get; set; }
    }
}
