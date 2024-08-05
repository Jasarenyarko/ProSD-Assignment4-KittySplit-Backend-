using System.Collections.Generic;

namespace KittySplit.Models
{
    public class Kitty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
