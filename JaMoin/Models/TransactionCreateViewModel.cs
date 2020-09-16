using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaMoin.Models
{
    public class TransactionCreateViewModel
    {
        public TransactionModel NewTransaction { get; set; }
        public List<string> AllUsernames { get; set; }
    }
}
