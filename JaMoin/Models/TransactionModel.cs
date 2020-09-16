using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JaMoin.Models
{
    public class TransactionModel
    {
        public TransactionModel()
        {
            Id = Guid.NewGuid().ToString();
        }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.None)]
        public string Id { get; set; }
        public string Kommentar { get; set; }
        public double GesamtBetrag { get; set; }
        public string GeldgeberEmail { get; set; }
        public List<SchuldenModel> Schulden { get; set; }

       
    }
}
