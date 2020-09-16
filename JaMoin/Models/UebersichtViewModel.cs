using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaMoin.Models
{
    public class UebersichtViewModel
    {
        public List<String> AllUsers { get; set; }
        public List<TransactionModel> AllTransactions { get; set; }
    }
}
