using System.Collections.Generic;
using KittySplit.Data.Repositories;
using KittySplit.Models;
using KittySplit.Data;


namespace KittySplit.Services
{
    public class KittyService : IKittyService
    {
        private readonly IKittyRepository _kittyRepository;
        private readonly IParticipantRepository _participantRepository;

        public KittyService()
        {
            _kittyRepository = new KittyRepository(new DataContext());
            _participantRepository = new ParticipantRepository(new DataContext());
        }

        public Kitty CreateKitty(string name)
        {
            var kitty = new Kitty { Name = name };
            return _kittyRepository.Create(kitty);
        }

        public void AddParticipant(Kitty kitty, string participantName)
        {
            _participantRepository.AddParticipants(kitty.Id, new List<string> { participantName });
        }

        public void RecordExpense(Kitty kitty, string payer, decimal amount, string description, List<string> involved)
        {
            var expense = new Expense { Payer = payer, Amount = amount, Description = description, Involved = new List<Participant>(), KittyId = kitty.Id };
            foreach (var name in involved)
            {
                expense.Involved.Add(new Participant { Name = name });
            }
            kitty.Expenses.Add(expense);
            _kittyRepository.Update(kitty);
        }

        public List<Expense> GetExpenses(Kitty kitty)
        {
            return kitty.Expenses;
        }

        public Dictionary<string, decimal> GetBalances(Kitty kitty)
        {
            var balances = new Dictionary<string, decimal>();
            foreach (var participant in kitty.Participants)
            {
                balances[participant.Name] = 0;
            }

            foreach (var expense in kitty.Expenses)
            {
                var share = expense.Amount / expense.Involved.Count;
                foreach (var participant in expense.Involved)
                {
                    balances[participant.Name] -= share;
                }
                balances[expense.Payer] += expense.Amount;
            }

            return balances;
        }
    }
}
