using System.Collections.Generic;
using KittySplit.Data.Repositories;
using KittySplit.Data;



namespace KittySplit.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService()
        {
            _participantRepository = new ParticipantRepository(new DataContext());
        }

        public void AddParticipants(int kittyId, List<string> participantNames)
        {
            _participantRepository.AddParticipants(kittyId, participantNames);
        }
    }
}
