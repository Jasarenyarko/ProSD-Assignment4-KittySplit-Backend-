using System.Collections.Generic;

namespace KittySplit.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Payer { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public List<Participant> Involved { get; set; }
        public int KittyId { get; set; }
        public Kitty Kitty { get; set; }
    }
}
