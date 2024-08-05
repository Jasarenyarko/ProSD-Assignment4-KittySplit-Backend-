using System.Collections.Generic;
using KittySplit.Models;

namespace KittySplit.Data.Repositories
{
    public interface IParticipantRepository
    {
        void AddParticipants(int kittyId, List<string> participantNames);
    }
}
