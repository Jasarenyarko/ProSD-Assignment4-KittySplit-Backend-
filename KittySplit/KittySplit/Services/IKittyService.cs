using System.Collections.Generic;
using KittySplit.Models;

namespace KittySplit.Services
{
    public interface IKittyService
    {
        Kitty CreateKitty(string name);
        void AddParticipant(Kitty kitty, string participantName);
        void RecordExpense(Kitty kitty, string payer, decimal amount, string description, List<string> involved);
        List<Expense> GetExpenses(Kitty kitty);
        Dictionary<string, decimal> GetBalances(Kitty kitty);
    }
}
