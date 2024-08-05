namespace KittySplit.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KittyId { get; set; }
        public Kitty Kitty { get; set; }
    }
}
