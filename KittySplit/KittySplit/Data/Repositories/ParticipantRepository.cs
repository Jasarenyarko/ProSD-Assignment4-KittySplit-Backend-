using System.Collections.Generic;
using System.Linq;
using KittySplit.Models;
using KittySplit.Data;


namespace KittySplit.Data.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly DataContext _context;

        public ParticipantRepository(DataContext context)
        {
            _context = context;
        }

        public void AddParticipants(int kittyId, List<string> participantNames)
        {
            var kitty = _context.Kitties.Find(kittyId);
            if (kitty != null)
            {
                foreach (var name in participantNames)
                {
                    kitty.Participants.Add(new Participant { Name = name });
                }
                _context.SaveChanges();
            }
        }
    }
}
