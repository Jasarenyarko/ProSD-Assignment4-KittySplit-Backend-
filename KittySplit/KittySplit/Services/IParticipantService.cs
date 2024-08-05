using System.Collections.Generic;
using KittySplit.Models;

namespace KittySplit.Services
{
    public interface IParticipantService
    {
        void AddParticipants(int kittyId, List<string> participantNames);
    }
}
