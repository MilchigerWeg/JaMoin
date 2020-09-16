using System.ComponentModel.DataAnnotations.Schema;

namespace JaMoin.Models
{
    public class SchuldenModel
    {
        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.None)]
        public string Id { get; set; }
        public double Betrag { get; set; }
        public string SchuldnerEmail { get; set; } 
    }
}
